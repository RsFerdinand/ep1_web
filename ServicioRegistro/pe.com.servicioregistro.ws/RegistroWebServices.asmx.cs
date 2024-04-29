using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using pe.com.servicioregistro.bal;
using pe.com.servicioregistro.bo;

namespace pe.com.servicioregistro.ws
{
    /// <summary>
    /// Summary description for RegistroWebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RegistroWebServices : System.Web.Services.WebService
    {

            BORol borol= new BORol();
            BALRol balrol= new BALRol();
            [WebMethod]
            public List<BORol> MostrarRoles()
            {
                List<BORol> roles =
               balrol.MostrarRoles().ToList();
                return roles;
            }
        [WebMethod]
        public List<BORol> MostrarRolesTodo()
        {
            List<BORol> roles =
           balrol.MostrarRolesTodo().ToList();
            return roles;
        }
        [WebMethod]
        public bool RegistrarRoles(BORol bc)
        {
            return balrol.RegistrarRoles(bc);
        }
        [WebMethod]
        public bool ActualizarRoles(BORol bc)
        {
            return balrol.ActualizarRoles(bc);
        }
        [WebMethod]
        public bool EliminarRoles(BORol bc)
        {
            return balrol.EliminarRoles(bc);
        }

        BOEmpleado boremp= new BOEmpleado();
        BALEmpleado balemp = new BALEmpleado ();
        [WebMethod]
        public List<BOEmpleado> MostrarEmpleados()
        {
            List<BOEmpleado> empleado =
           balemp.MostrarEmpleados().ToList();
            return empleado;
        }
        [WebMethod]
        public List<BOEmpleado> MostrarEmpleadosTodo()
        {
            List<BOEmpleado> empleado =
           balemp.MostrarEmpleadosTodo().ToList();
            return empleado;
        }
        [WebMethod]
        public bool RegistrarEmpleados(BOEmpleado bc)
        {
            return balemp.RegistrarEmpleados(bc);
        }
        [WebMethod]
        public bool ActualizarEmpleados(BOEmpleado bc)
        {
            return balemp.ActualizarEmpleados(bc);
        }
        [WebMethod]
        public bool EliminarEmpleados(BOEmpleado bc)
        {
            return balemp.EliminarEmpleados(bc);
        }

        BODistrito bordist= new BODistrito();
        BALDistrito baldist= new BALDistrito();
        [WebMethod]
        public List<BODistrito> MostrarDistritos()
        {
            List<BODistrito> distrito =
           baldist.MostrarDistritos().ToList();
            return distrito;
        }
        [WebMethod]
        public List<BODistrito> MostrarDistritosTodo()
        {
            List<BODistrito> distrito =
           baldist.MostrarDistritosTodo().ToList();
            return distrito;
        }
        [WebMethod]
        public bool RegistrarDistritos(BODistrito bc)
        {
            return baldist.RegistrarDistritos(bc);
        }
        [WebMethod]
        public bool ActualizarDistritos(BODistrito bc)
        {
            return baldist.ActualizarDistritos(bc);
        }
        [WebMethod]
        public bool EliminarDistritos(BODistrito bc)
        {
            return baldist.EliminarDistritos(bc);
        }




    }
} 
        
    
