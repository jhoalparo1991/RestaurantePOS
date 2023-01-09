using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DRoles
    {

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public static void mostrar(DataTable dt,bool activo)
        {
            SqlConnection con = Connection.connect();

            string sql = "";

            if (activo)
            {
                sql = "SELECT * FROM Roles WHERE activo=1";
            }
            else
            {
                sql = "SELECT * FROM Roles WHERE activo=0";
            }
            SqlDataAdapter data = new SqlDataAdapter(sql, con);
            try
            {
                data.Fill(dt);
                con.Open();
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

        }
        public static bool guardar(DRoles roles, int opcion)
        {
            bool result = false;
            SqlConnection con = Connection.connect();
            SqlCommand cmd = new SqlCommand("sp_guardar_roles", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", roles.Codigo);
                cmd.Parameters.AddWithValue("@nombre", roles.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", roles.Descripcion);
                cmd.Parameters.AddWithValue("@activo", roles.Activo);
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
                if(con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
          
            return result;
        }

      
    }
}
