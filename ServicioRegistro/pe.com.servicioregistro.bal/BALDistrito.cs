using pe.com.servicioregistro.bo;
using pe.com.servicioregistro.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.servicioregistro.bal
{
    public class BALDistrito
    {
        DALDistrito daldist = new DALDistrito();

        public List<BODistrito> MostrarDistritos()
        {
            return daldist.MostrarDistritos();
        }
        public List<BODistrito> MostrarDistritosTodo()
        {
            return daldist.MostrarDistritosTodo();
        }
        public bool RegistrarDistritos(BODistrito bc)
        {
            return daldist.RegistrarDistritos(bc);
        }
        public bool ActualizarDistritos(BODistrito bc)
        {
            return daldist.ActualizarDistritos(bc);
        }

        public bool EliminarDistritos(BODistrito bc)
        {
            return daldist.EliminarDistritos(bc);
        }
    }
}
