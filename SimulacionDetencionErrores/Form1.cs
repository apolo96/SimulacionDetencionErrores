using System;
using MetroFramework.Forms;
using MetroFramework;
using System.Windows.Forms;

namespace SimulacionDetencionErrores
{
    public partial class Form1 : MetroForm , IDetencionError
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String bite = txtDato.Text.ToString() + "0";

            string[] bits =  new string[bite.Length];

            bits = explode(bite);

            bite = String.Join("",generacion(bits));

            txtDatoError.Text = bite;

            mtDato.Text = bite;

        }

        public string[] generacion(string[] bite)
        {
            int contarParidad = 0;
            int longitudBites = bite.Length;
            for (int i = 0; i < longitudBites; i++)
            {
                if (bite[i] == "1") contarParidad++;
            }
            bite[longitudBites - 1] = (contarParidad % 2 != 0)?"1":"0";            
            return bite;
        }

        public bool comprobacion(string[] bite)
        {
            int contarParidad = 0;
            int longitudBites = bite.Length;
            for (int i = 0; i < longitudBites; i++)
            {
                if (bite[i] == "1") contarParidad++;
            }
            if (contarParidad % 2 != 0) return false;

            return true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String bite = txtDatoError.Text.ToString();

            mtError.Text = bite;

            string[] bits = new string[bite.Length + 1];

            bits = explode(bite);

            if (comprobacion(bits)) MetroMessageBox.Show(this, "Detencíon de Error", "Dato sin Error",MessageBoxButtons.OK, MessageBoxIcon.Question);
            else MetroMessageBox.Show(this, "Detencíon de Error", "Error encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
        }

        private string[] explode(string bite)
        {
            int lenBite = bite.Length;
            string[] bits = new string[lenBite];
            for (int i = 0; i < lenBite ; i++)
            {
                bits[i] = bite.Substring(i, 1);
            }
            return bits;
        }

        private void mtDato_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Teoria", "El número de bits de datos 1 es par, por lo tanto, el bit de paridad se determina en 0. Por el contrario,los bits de datos son impares, por lo que el bit de paridad se convierte en 1", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
