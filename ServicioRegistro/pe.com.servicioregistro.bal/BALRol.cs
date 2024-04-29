using pe.com.servicioregistro.bo;
using pe.com.servicioregistro.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.servicioregistro.bal
{
    public class BALRol
    {
        DALRol dalrol = new DALRol();

        public List<BORol> MostrarRoles()
        {
            return dalrol.MostrarRoles();
        }
        public List<BORol> MostrarRolesTodo()
        {
            return dalrol.MostrarRoles();
        }
        public bool RegistrarRoles(BORol bc)
        {
            return dalrol.RegistrarRoles(bc);
        }
        public bool ActualizarRoles(BORol bc)
        {
            return dalrol.ActualizarRoles(bc);
        }

        public bool EliminarRoles(BORol bc)
        {
            return dalrol.EliminarRoles(bc);
        }
    }
}
