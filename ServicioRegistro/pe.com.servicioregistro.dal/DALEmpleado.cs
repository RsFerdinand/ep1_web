using pe.com.servicioregistro.bo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.servicioregistro.dal
{
    public class DALEmpleado
    {
        Conexion objconexion = new Conexion();
        private SqlCommand cmdrol;
        private SqlDataReader drrol;
        int res = 0;
        public List<BOEmpleado> MostrarEmpleados()
        {
            List<BOEmpleado> empleado = new List<BOEmpleado>();
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_MostrarEmpleados";
                cmdrol.Connection = objconexion.Conectar();
                drrol = cmdrol.ExecuteReader();
                while (drrol.Read())
                {
                    BOEmpleado objgen = new BOEmpleado();

                    objgen.codigoempleado =
                    Convert.ToInt32(drrol["codigoempleado"].ToString());
                    objgen.nombrempleado = drrol["nombrempleado"].ToString();
                    objgen.apellidopempleado = drrol["apellidopempleado"].ToString();
                    objgen.apellidomempleado = drrol["apellidomempleado"].ToString();
                    objgen.documentoempleado = drrol["documentoempleado"].ToString();
                    objgen.fechaempleado = Convert.ToDateTime(drrol["fechaempleado"]);
                    objgen.direccionempleado = drrol["direccionempleado"].ToString();
                    objgen.telefonoempleado = drrol["telefonoempleado"].ToString();
                    objgen.celularempleado = drrol["celularempleado"].ToString();
                    objgen.correoempleado = drrol["correoempleado"].ToString();
                    objgen.sexoempleado = drrol["sexoempleado"].ToString();
                    objgen.usuarioempleado = drrol["usuarioempleado"].ToString();
                    objgen.claveempleado = drrol["claveempleado"].ToString();
                    objgen.estadoempleado = Convert.ToInt32(drrol["estadoempleado"].ToString());
                    objgen.codigorol = Convert.ToInt32(drrol["codigorol"].ToString());
                    objgen.codigodistrito = Convert.ToInt32(drrol["codigodistrito"].ToString());
                    empleado.Add(objgen);
                }
                return empleado;
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
        public List<BOEmpleado> MostrarEmpleadosTodo()
        {
            List<BOEmpleado> empleado = new List<BOEmpleado>();
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_MostrarEmpleadosTodo";
                cmdrol.Connection = objconexion.Conectar();
                drrol = cmdrol.ExecuteReader();
                while (drrol.Read())
                {
                    BOEmpleado objgen = new BOEmpleado();

                    objgen.codigoempleado =
                    Convert.ToInt32(drrol["codigoempleado"].ToString());
                    objgen.nombrempleado = drrol["nombrempleado"].ToString();
                    objgen.apellidopempleado = drrol["apellidopempleado"].ToString();
                    objgen.apellidomempleado = drrol["apellidomempleado"].ToString();
                    objgen.documentoempleado = drrol["documentoempleado"].ToString();
                    objgen.fechaempleado = Convert.ToDateTime(drrol["fechaempleado"]);
                    objgen.direccionempleado = drrol["direccionempleado"].ToString();
                    objgen.telefonoempleado = drrol["telefonoempleado"].ToString();
                    objgen.celularempleado = drrol["celularempleado"].ToString();
                    objgen.correoempleado = drrol["correoempleado"].ToString();
                    objgen.sexoempleado = drrol["sexoempleado"].ToString();
                    objgen.usuarioempleado = drrol["usuarioempleado"].ToString();
                    objgen.claveempleado = drrol["claveempleado"].ToString();
                    objgen.estadoempleado = Convert.ToInt32(drrol["estadoempleado"].ToString());
                    objgen.codigorol = Convert.ToInt32(drrol["codigorol"].ToString());
                    objgen.codigodistrito = Convert.ToInt32(drrol["codigodistrito"].ToString());
                    empleado.Add(objgen);
                }
                return empleado;
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
        public bool RegistrarEmpleados(BOEmpleado bc)
        {
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_InsertarEmpleado";
                cmdrol.Connection = objconexion.Conectar();
                cmdrol.Parameters.AddWithValue("@nombrempleado", bc.nombrempleado);
                cmdrol.Parameters.AddWithValue("@apellidopempleado", bc.apellidopempleado);
                cmdrol.Parameters.AddWithValue("@apellidomempleado", bc.apellidomempleado);
                cmdrol.Parameters.AddWithValue("@documentoempleado", bc.documentoempleado);
                cmdrol.Parameters.AddWithValue("@fechaempleado", bc.fechaempleado);
                cmdrol.Parameters.AddWithValue("@direccionempleado", bc.direccionempleado);
                cmdrol.Parameters.AddWithValue("@telefonoempleado", bc.telefonoempleado);
                cmdrol.Parameters.AddWithValue("@celularempleado", bc.celularempleado);
                cmdrol.Parameters.AddWithValue("@correoempleado", bc.correoempleado);
                cmdrol.Parameters.AddWithValue("@sexoempleado", bc.sexoempleado);
                cmdrol.Parameters.AddWithValue("@usuarioempleado", bc.usuarioempleado);
                cmdrol.Parameters.AddWithValue("@claveempleado", bc.claveempleado);
                cmdrol.Parameters.AddWithValue("@estadoempleado", bc.estadoempleado);
                cmdrol.Parameters.AddWithValue("@codigorol", bc.codigodistrito);
                cmdrol.Parameters.AddWithValue("@codigodistrito", bc.codigodistrito);
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

        public bool ActualizarEmpleados(BOEmpleado bc)
        {
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_ActualizarEmpleado";
                cmdrol.Connection = objconexion.Conectar();
                cmdrol.Parameters.AddWithValue("@nombrempleado", bc.nombrempleado);
                cmdrol.Parameters.AddWithValue("@apellidopempleado", bc.apellidopempleado);
                cmdrol.Parameters.AddWithValue("@apellidomempleado", bc.apellidomempleado);
                cmdrol.Parameters.AddWithValue("@documentoempleado", bc.documentoempleado);
                cmdrol.Parameters.AddWithValue("@fechaempleado", bc.fechaempleado);
                cmdrol.Parameters.AddWithValue("@direccionempleado", bc.direccionempleado);
                cmdrol.Parameters.AddWithValue("@telefonoempleado", bc.telefonoempleado);
                cmdrol.Parameters.AddWithValue("@celularempleado", bc.celularempleado);
                cmdrol.Parameters.AddWithValue("@correoempleado", bc.correoempleado);
                cmdrol.Parameters.AddWithValue("@sexoempleado", bc.sexoempleado);
                cmdrol.Parameters.AddWithValue("@usuarioempleado", bc.usuarioempleado);
                cmdrol.Parameters.AddWithValue("@claveempleado", bc.claveempleado);
                cmdrol.Parameters.AddWithValue("@estadoempleado", bc.estadoempleado);
                cmdrol.Parameters.AddWithValue("@codigorol", bc.codigodistrito);
                cmdrol.Parameters.AddWithValue("@codigodistrito", bc.codigodistrito);
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
        public bool EliminarEmpleados(BOEmpleado bc)
        {
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_EliminarEmpleado";
                cmdrol.Connection = objconexion.Conectar();
                cmdrol.Parameters.AddWithValue("@codigoempleado", bc.codigoempleado);
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
