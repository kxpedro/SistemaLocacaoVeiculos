using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SLV.Database
{
    public class Commands
    {
        private static string StringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=P:\\Repository\\SistemaLocacaoVeiculos\\SLV\\SLV\\App_Data\\Database.mdf;Integrated Security=True";
        
        public static SqlConnection Conectar()
        {            
            SqlConnection sqlConn = new SqlConnection(StringConnection);
            return sqlConn;
        }

        public static void Insert<T>(T classe, string tabela)
        {
            var sqlCon = Conectar();
            SqlCommand cmd = new SqlCommand("INSERT INTO "+tabela+" VALUES ("+classe+")", sqlCon);

            sqlCon.Open();
            cmd.ExecuteNonQuery();
            sqlCon.Close();            
        }

    }
}