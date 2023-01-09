using System.Data.SqlClient;
using System;

namespace CapaDatos
{
    public class Connection
    {

        private static string INITIAL_CATALOG="Restaurante";
        private static string USERNAME="sa";
        private static string PASSWORD="masterkey";
        private static bool INTEGRATED_SECURITY=true;
        private static string DATA_SOURCE= $"{Environment.MachineName}\\SQLEXPRESS";
        private static SqlConnection CON = null;

        
        public static SqlConnection connect()
        {
            try
            {
                SqlConnectionStringBuilder builder = 
                    new SqlConnectionStringBuilder();
                builder.InitialCatalog = INITIAL_CATALOG;
                builder.IntegratedSecurity= INTEGRATED_SECURITY;
                builder.DataSource= DATA_SOURCE;
                
                CON = new SqlConnection(builder.ToString());

                return CON;


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
