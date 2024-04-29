using pe.com.servicioregistro.bo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.servicioregistro.dal
{
    public class DALDistrito
    {
        Conexion objconexion = new Conexion();
        private SqlCommand cmdrol;
        private SqlDataReader drrol;
        int res = 0;
        public List<BODistrito> MostrarDistritos()
        {
         List<BODistrito> distrito = new List<BODistrito>();
            try
            {
            cmdrol = new SqlCommand();
            cmdrol.CommandType = CommandType.StoredProcedure;
            cmdrol.CommandText = "SP_MostrarDistritos";
            cmdrol.Connection = objconexion.Conectar();
            drrol = cmdrol.ExecuteReader();
            while (drrol.Read())
            {
                    BODistrito objgen = new BODistrito();

                objgen.codigo =
                Convert.ToInt32(drrol["codigodistrito"].ToString());
                objgen.nombredistrito = drrol["nombredistrito"].ToString();
                objgen.estadodistrito = Convert.ToInt32(drrol["estadodistrito"].ToString());
                   distrito.Add(objgen);
            }
            return distrito;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return null;
        }
        finally
        {
            objconexion.CerrarConexion();
        }

    }
    public List<BODistrito> MostrarDistritosTodo()
    {
        List<BODistrito> distrito = new List<BODistrito>();
        try
        {
            cmdrol = new SqlCommand();
            cmdrol.CommandType = CommandType.StoredProcedure;
            cmdrol.CommandText = "SP_MostrarDistritosTodo";
            cmdrol.Connection = objconexion.Conectar();
            drrol = cmdrol.ExecuteReader();
            while (drrol.Read())
            {
                    BODistrito objgen = new BODistrito();

                objgen.codigo =
                Convert.ToInt32(drrol["codigodistrito"].ToString());
                objgen.nombredistrito = drrol["nombredistrito"].ToString();
                objgen.estadodistrito = Convert.ToInt32(drrol["estadodistrito"].ToString());
                    distrito.Add(objgen);
            }
            return distrito;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return null;
        }
        finally
        {
            objconexion.CerrarConexion();
        }
    }
    public bool RegistrarDistritos(BODistrito bc)
    {
        try
        {
            cmdrol = new SqlCommand();
            cmdrol.CommandType = CommandType.StoredProcedure;
            cmdrol.CommandText = "SP_InsertarDistrito";
            cmdrol.Connection = objconexion.Conectar();
            cmdrol.Parameters.AddWithValue("@nombredistrito", bc.nombredistrito);
            cmdrol.Parameters.AddWithValue("@estadodistrito", bc.estadodistrito);
            res = cmdrol.ExecuteNonQuery();
            if (res == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return false;
        }
        finally
        {
            objconexion.CerrarConexion();
        }
    }

    public bool ActualizarDistritos(BODistrito bc)
    {
        try
        {
            cmdrol = new SqlCommand();
            cmdrol.CommandType = CommandType.StoredProcedure;
            cmdrol.CommandText = "SP_ActualizarDistrito";
            cmdrol.Connection = objconexion.Conectar();
            cmdrol.Parameters.AddWithValue("@codigodistrito", bc.codigo);
            cmdrol.Parameters.AddWithValue("@nombredistrito", bc.nombredistrito);
            cmdrol.Parameters.AddWithValue("@estadodistrito", bc.estadodistrito);
            res = cmdrol.ExecuteNonQuery();
            if (res == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return false;
        }
        finally
        {
            objconexion.CerrarConexion();
        }
    }
    public bool EliminarDistritos(BODistrito bc)
    {
        try
        {
            cmdrol = new SqlCommand();
            cmdrol.CommandType = CommandType.StoredProcedure;
            cmdrol.CommandText = "SP_EliminarDistrito";
            cmdrol.Connection = objconexion.Conectar();
            cmdrol.Parameters.AddWithValue("@codigodistrito", bc.codigo);
            res = cmdrol.ExecuteNonQuery();
            if (res == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return false;
        }
        finally
        {
            objconexion.CerrarConexion();
        }
    }
}

}
