using pe.com.servicioregistro.bo;
using pe.com.servicioregistro.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.servicioregistro.bal
{
    public class BALEmpleado
    {
        DALEmpleado dalemp = new DALEmpleado();

        public List<BOEmpleado> MostrarEmpleados()
        {
            return dalemp.MostrarEmpleados();
        }
        public List<BOEmpleado> MostrarEmpleadosTodo()
        {
            return dalemp.MostrarEmpleadosTodo();
        }
        public bool RegistrarEmpleados(BOEmpleado bc)
        {
            return dalemp.RegistrarEmpleados(bc);
        }
        public bool ActualizarEmpleados(BOEmpleado bc)
        {
            return dalemp.ActualizarEmpleados(bc);
        }

        public bool EliminarEmpleados(BOEmpleado bc)
        {
            return dalemp.EliminarEmpleados(bc);
        }
    }
}
