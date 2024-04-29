using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.servicioregistro.bo
{
    public class BOEmpleado
    {
        public int codigoempleado { get; set; }
        public string nombrempleado { get; set; }
        public string apellidopempleado { get; set; }
        public string apellidomempleado { get; set; }
        public string documentoempleado { get; set; }
        public DateTime fechaempleado { get; set; }
        public string direccionempleado { get; set; }
        public string telefonoempleado { get; set; }
        public string celularempleado { get; set; }
        public string correoempleado { get; set; }
        public string sexoempleado { get; set; }
        public string usuarioempleado { get; set; }
        public string claveempleado { get; set; }
        public int estadoempleado { get; set; }
        public int codigorol { get; set; }
        public int codigodistrito { get; set; }
        public BOEmpleado()
            {
            }
        
    }
}
