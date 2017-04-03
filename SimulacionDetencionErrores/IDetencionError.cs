using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulacionDetencionErrores
{
    interface IDetencionError
    {
        string[] generacion(string[] bites);
        bool comprobacion(string[] bites);
    }
}
