using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class SQL
    {

        public static bool deleteById(string table,string fieldPrimary, int code )
        {
            bool result = false;
            SqlConnection con = Connection.connect();
            string sql = $"DELETE FROM {table} WHERE  {fieldPrimary}={code}";

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
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return result;
        }

        public static void llenarComboBox(DataTable dt,string table)
        {
            SqlConnection con = Connection.connect();
            string sql = $"SELECT * FROM {table} WHERE activo=1 ORDER BY codigo";
            SqlDataAdapter data = new SqlDataAdapter(sql,con);
            try
            {
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
    }
}
