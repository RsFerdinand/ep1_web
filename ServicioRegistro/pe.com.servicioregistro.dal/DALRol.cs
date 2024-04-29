using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.servicioregistro.bo;

namespace pe.com.servicioregistro.dal
{
    public class DALRol
    {
        Conexion objconexion = new Conexion();
        private SqlCommand cmdrol;
        private SqlDataReader drrol;
        int res = 0;
        public List<BORol> MostrarRoles()
        {
            List<BORol> roles = new List<BORol>();
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_MostrarRoles";
                cmdrol.Connection = objconexion.Conectar();
                drrol = cmdrol.ExecuteReader();
                while (drrol.Read())
                {
                    BORol objgen = new BORol();

                    objgen.codigo =
                    Convert.ToInt32(drrol["codigorol"].ToString());
                    objgen.nombrerol = drrol["nombrerol"].ToString();
                    objgen.estadorol = Convert.ToInt32(drrol["estadorol"].ToString());
                    roles.Add(objgen);
                }
                return roles;
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
        public List<BORol> MostrarRolesTodo()
        {
            List<BORol> roles = new List<BORol>();
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_MostrarRolesTodo";
                cmdrol.Connection = objconexion.Conectar();
                drrol = cmdrol.ExecuteReader();
                while (drrol.Read())
                {
                    BORol objgen = new BORol();

                    objgen.codigo =
                    Convert.ToInt32(drrol["codigorol"].ToString());
                    objgen.nombrerol = drrol["nombrerol"].ToString();
                    objgen.estadorol = Convert.ToInt32(drrol["estadorol"].ToString());
                    roles.Add(objgen);
                }
                return roles;
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
        public bool RegistrarRoles(BORol bc)
        {
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_InsertarRol";
                cmdrol.Connection = objconexion.Conectar();
                cmdrol.Parameters.AddWithValue("@nombrerol", bc.nombrerol);
                cmdrol.Parameters.AddWithValue("@estadorol", bc.estadorol);
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

        public bool ActualizarRoles(BORol bc)
        {
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_ActualizarRol";
                cmdrol.Connection = objconexion.Conectar();
                cmdrol.Parameters.AddWithValue("@codigorol", bc.codigo);
                cmdrol.Parameters.AddWithValue("@nombrerol", bc.nombrerol);
                cmdrol.Parameters.AddWithValue("@estadorol", bc.estadorol);
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
        public bool EliminarRoles(BORol bc)
        {
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_EliminarRol";
                cmdrol.Connection = objconexion.Conectar();
                cmdrol.Parameters.AddWithValue("@codigorol", bc.codigo);
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
