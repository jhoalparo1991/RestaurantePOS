using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DSalones
    {

        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Impuesto { get; set; }
        public bool Activo { get; set; }

        public static void mostrar(DataTable dt, bool activo)
        {
            SqlConnection con = Connection.connect();

            string sql = "";

            if (activo)
            {
                sql = "SELECT * FROM Salones WHERE activo=1";
            }
            else
            {
                sql = "SELECT * FROM Salones WHERE activo=0";
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
        public static bool guardar(DSalones salon, int opcion)
        {
            bool result = false;
            SqlConnection con = Connection.connect();

            string sql = "";

            if(opcion== 0) {

                sql = "INSERT INTO Salones (descripcion,impuesto,activo) " +
                    "VALUES(@descripcion,@impuesto,@activo)";
            }
            else
            {
                sql = "UPDATE Salones SET " +
                    "descripcion=@descripcion, " +
                    "impuesto=@impuesto, " +
                    "activo=@activo " +
                    "WHERE " +
                    "codigo = @codigo";
            }

            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@descripcion", salon.Descripcion);
                cmd.Parameters.AddWithValue("@activo", salon.Activo);
                cmd.Parameters.AddWithValue("@impuesto", salon.Impuesto);
                if(opcion != 0)
                {
                    cmd.Parameters.AddWithValue("@codigo", salon.Codigo);
                }

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
    }
}
