namespace SimulacionDetencionErrores
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metodos = new MetroFramework.Controls.MetroTabControl();
            this.VCR = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.mtError = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDatoError = new MetroFramework.Controls.MetroTextBox();
            this.mtDato = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDato = new MetroFramework.Controls.MetroTextBox();
            this.LRC = new MetroFramework.Controls.MetroTabPage();
            this.CRC = new MetroFramework.Controls.MetroTabPage();
            this.SC = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnEnviar = new MetroFramework.Controls.MetroButton();
            this.metodos.SuspendLayout();
            this.VCR.SuspendLayout();
            this.SuspendLayout();
            // 
            // metodos
            // 
            this.metodos.Controls.Add(this.VCR);
            this.metodos.Controls.Add(this.LRC);
            this.metodos.Controls.Add(this.CRC);
            this.metodos.Controls.Add(this.SC);
            this.metodos.Location = new System.Drawing.Point(23, 63);
            this.metodos.Name = "metodos";
            this.metodos.SelectedIndex = 0;
            this.metodos.Size = new System.Drawing.Size(716, 389);
            this.metodos.Style = MetroFramework.MetroColorStyle.Teal;
            this.metodos.TabIndex = 0;
            this.metodos.Tag = "";
            this.metodos.UseSelectable = true;
            // 
            // VCR
            // 
            this.VCR.Controls.Add(this.btnEnviar);
            this.VCR.Controls.Add(this.metroLabel6);
            this.VCR.Controls.Add(this.btnAceptar);
            this.VCR.Controls.Add(this.mtError);
            this.VCR.Controls.Add(this.metroLabel2);
            this.VCR.Controls.Add(this.txtDatoError);
            this.VCR.Controls.Add(this.mtDato);
            this.VCR.Controls.Add(this.metroLabel1);
            this.VCR.Controls.Add(this.txtDato);
            this.VCR.HorizontalScrollbarBarColor = true;
            this.VCR.HorizontalScrollbarHighlightOnWheel = false;
            this.VCR.HorizontalScrollbarSize = 10;
            this.VCR.Location = new System.Drawing.Point(4, 38);
            this.VCR.Name = "VCR";
            this.VCR.Size = new System.Drawing.Size(708, 347);
            this.VCR.TabIndex = 0;
            this.VCR.Text = "Verficacíon Vertical (VRC)";
            this.VCR.VerticalScrollbarBarColor = true;
            this.VCR.VerticalScrollbarHighlightOnWheel = false;
            this.VCR.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(14, 18);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(286, 25);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Verificacion de Redundancia Vertical";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(54, 288);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(114, 39);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Fx Comprobacíon";
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // mtError
            // 
            this.mtError.ActiveControl = null;
            this.mtError.Location = new System.Drawing.Point(398, 133);
            this.mtError.Name = "mtError";
            this.mtError.Size = new System.Drawing.Size(236, 137);
            this.mtError.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtError.TabIndex = 8;
            this.mtError.Text = "Byte Error";
            this.mtError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtError.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtError.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(398, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Ingresar Error";
            // 
            // txtDatoError
            // 
            // 
            // 
            // 
            this.txtDatoError.CustomButton.Image = null;
            this.txtDatoError.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.txtDatoError.CustomButton.Name = "";
            this.txtDatoError.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDatoError.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDatoError.CustomButton.TabIndex = 1;
            this.txtDatoError.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDatoError.CustomButton.UseSelectable = true;
            this.txtDatoError.CustomButton.Visible = false;
            this.txtDatoError.Lines = new string[0];
            this.txtDatoError.Location = new System.Drawing.Point(398, 95);
            this.txtDatoError.MaxLength = 32767;
            this.txtDatoError.Name = "txtDatoError";
            this.txtDatoError.PasswordChar = '\0';
            this.txtDatoError.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDatoError.SelectedText = "";
            this.txtDatoError.SelectionLength = 0;
            this.txtDatoError.SelectionStart = 0;
            this.txtDatoError.ShortcutsEnabled = true;
            this.txtDatoError.Size = new System.Drawing.Size(236, 23);
            this.txtDatoError.TabIndex = 6;
            this.txtDatoError.UseSelectable = true;
            this.txtDatoError.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDatoError.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtDato
            // 
            this.mtDato.ActiveControl = null;
            this.mtDato.Location = new System.Drawing.Point(54, 133);
            this.mtDato.Name = "mtDato";
            this.mtDato.Size = new System.Drawing.Size(236, 137);
            this.mtDato.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtDato.TabIndex = 5;
            this.mtDato.Text = "Byte";
            this.mtDato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDato.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtDato.UseSelectable = true;
            this.mtDato.Click += new System.EventHandler(this.mtDato_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Ingresar Dato";
            // 
            // txtDato
            // 
            // 
            // 
            // 
            this.txtDato.CustomButton.Image = null;
            this.txtDato.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.txtDato.CustomButton.Name = "";
            this.txtDato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDato.CustomButton.TabIndex = 1;
            this.txtDato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDato.CustomButton.UseSelectable = true;
            this.txtDato.CustomButton.Visible = false;
            this.txtDato.Lines = new string[0];
            this.txtDato.Location = new System.Drawing.Point(54, 95);
            this.txtDato.MaxLength = 32767;
            this.txtDato.Name = "txtDato";
            this.txtDato.PasswordChar = '\0';
            this.txtDato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDato.SelectedText = "";
            this.txtDato.SelectionLength = 0;
            this.txtDato.SelectionStart = 0;
            this.txtDato.ShortcutsEnabled = true;
            this.txtDato.Size = new System.Drawing.Size(236, 23);
            this.txtDato.TabIndex = 2;
            this.txtDato.UseSelectable = true;
            this.txtDato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LRC
            // 
            this.LRC.HorizontalScrollbarBarColor = true;
            this.LRC.HorizontalScrollbarHighlightOnWheel = false;
            this.LRC.HorizontalScrollbarSize = 10;
            this.LRC.Location = new System.Drawing.Point(4, 38);
            this.LRC.Name = "LRC";
            this.LRC.Size = new System.Drawing.Size(874, 347);
            this.LRC.TabIndex = 1;
            this.LRC.Text = "Verificacíon Longitudinal (LRC)";
            this.LRC.VerticalScrollbarBarColor = true;
            this.LRC.VerticalScrollbarHighlightOnWheel = false;
            this.LRC.VerticalScrollbarSize = 10;
            // 
            // CRC
            // 
            this.CRC.HorizontalScrollbarBarColor = true;
            this.CRC.HorizontalScrollbarHighlightOnWheel = false;
            this.CRC.HorizontalScrollbarSize = 10;
            this.CRC.Location = new System.Drawing.Point(4, 38);
            this.CRC.Name = "CRC";
            this.CRC.Size = new System.Drawing.Size(874, 347);
            this.CRC.TabIndex = 2;
            this.CRC.Text = "Verificacíon Ciclica (CRC)";
            this.CRC.VerticalScrollbarBarColor = true;
            this.CRC.VerticalScrollbarHighlightOnWheel = false;
            this.CRC.VerticalScrollbarSize = 10;
            // 
            // SC
            // 
            this.SC.HorizontalScrollbarBarColor = true;
            this.SC.HorizontalScrollbarHighlightOnWheel = false;
            this.SC.HorizontalScrollbarSize = 10;
            this.SC.Location = new System.Drawing.Point(4, 38);
            this.SC.Name = "SC";
            this.SC.Size = new System.Drawing.Size(874, 347);
            this.SC.TabIndex = 3;
            this.SC.Text = "Suma de Comprobacíon";
            this.SC.VerticalScrollbarBarColor = true;
            this.SC.VerticalScrollbarHighlightOnWheel = false;
            this.SC.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(654, 455);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 15);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Copyright © 2017";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(605, 455);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 15);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Apolo96";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(398, 288);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(116, 39);
            this.btnEnviar.TabIndex = 15;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseSelectable = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 482);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metodos);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Detección de Errores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metodos.ResumeLayout(false);
            this.VCR.ResumeLayout(false);
            this.VCR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metodos;
        private MetroFramework.Controls.MetroTabPage VCR;
        private MetroFramework.Controls.MetroTabPage LRC;
        private MetroFramework.Controls.MetroTabPage CRC;
        private MetroFramework.Controls.MetroTile mtDato;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDato;
        private MetroFramework.Controls.MetroTile mtError;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDatoError;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTabPage SC;
        private MetroFramework.Controls.MetroButton btnEnviar;
    }
}

