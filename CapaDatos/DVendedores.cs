using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DVendedores
    {

        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoDoc { get; set; }
        public string NroDoc { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Clave { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Comision { get; set; }
        public decimal Salario { get; set; }
        public int RolId { get; set; }

        public static void mostrar(DataTable dt, string buscar)
        {
            SqlConnection con = Connection.connect();
            SqlDataAdapter data = new SqlDataAdapter("sp_mostrar_vendedores", con);
            try
            {
                data.SelectCommand.Parameters.AddWithValue("@buscar", buscar);    
                data.Fill(dt);
                con.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                dt = null;
            }
            finally
            {
                con.Close();
            }
        }

        public static void iniciarSesion(DataTable dt, string clave)
        {
            SqlConnection con = Connection.connect();
            SqlDataAdapter data = new SqlDataAdapter("cp_iniciar_sesion", con);
            try
            {
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.AddWithValue("@clave", clave);
                data.SelectCommand.Parameters.AddWithValue("@pc_name", Environment.MachineName);
                data.Fill(dt);
                con.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                dt = null;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool guardar(DVendedores v, int opcion)
        {
            bool result = false;
            SqlConnection con = Connection.connect();
            SqlCommand cmd = new SqlCommand("sp_guardar_vendedor", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", v.Codigo);
                cmd.Parameters.AddWithValue("@nombres", v.Nombres);
                cmd.Parameters.AddWithValue("@apellidos", v.Apellidos);
                cmd.Parameters.AddWithValue("@tipo_doc", v.TipoDoc);
                cmd.Parameters.AddWithValue("@nro_doc", v.NroDoc);
                cmd.Parameters.AddWithValue("@direccion", v.Direccion);
                cmd.Parameters.AddWithValue("@telefono", v.Telefono);
                cmd.Parameters.AddWithValue("@celular", v.Celular);
                cmd.Parameters.AddWithValue("@email", v.Email);
                cmd.Parameters.AddWithValue("@ciudad", v.Ciudad);
                cmd.Parameters.AddWithValue("@pais", v.Pais);
                cmd.Parameters.AddWithValue("@clave", v.Clave);
                cmd.Parameters.AddWithValue("@foto", v.Foto);
                cmd.Parameters.AddWithValue("@activo", v.Activo);
                cmd.Parameters.AddWithValue("@salario_base", v.SalarioBase);
                cmd.Parameters.AddWithValue("@comision", v.Comision);
                cmd.Parameters.AddWithValue("@role_id", v.RolId);
                cmd.Parameters.AddWithValue("@opcion", opcion);

                con.Open();
                result = cmd.ExecuteNonQuery() != 0 ? true : false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return result;
        }

        public static bool verificarEstado(int vendedorId)
        {
            bool result = false;
            SqlConnection con = Connection.connect();
            string sql = $"select estado from Inicio_sesion where vendedor_id={vendedorId}";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.CommandType = CommandType.Text;
                
                con.Open();
                result = cmd.ExecuteNonQuery() != 0 ? true : false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return result;
        }

        public static bool cambiarEstado(int vendedorId)
        {
            bool result = false;
            SqlConnection con = Connection.connect();
            string sql = $"update Inicio_sesion set estado='inactivo' where vendedor_id={vendedorId}";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.CommandType = CommandType.Text;

                con.Open();
                result = cmd.ExecuteNonQuery() != 0 ? true : false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return result;
        }

        public static void obtenerDatosInicioSesion(DataTable dt)
        {
            SqlConnection con = Connection.connect();
            SqlDataAdapter data = new SqlDataAdapter("sp_obtener_datos_inicio_sesion", con);
            try
            {
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.AddWithValue("@pc", Environment.MachineName);
                data.Fill(dt);
                con.Open();
            }
            catch (Exception e)
            {
                dt = null;
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
