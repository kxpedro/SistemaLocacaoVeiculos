using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

        public static void Insert<T>(T values, T tabela)
        {
            var sqlCon = Conectar();                      

            SqlCommand cmd = new SqlCommand("INSERT INTO "+tabela+" VALUES ("+ values + ")", sqlCon);

            sqlCon.Open();
            cmd.ExecuteNonQuery();
            sqlCon.Close();            
        }

        public static void Select<T>(T tabela)
        {
            var sqlCon = Conectar();

            SqlCommand cmd = new SqlCommand("Select * from " + tabela, sqlCon);
            DataTable dt = new DataTable();

            sqlCon.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            sqlCon.Close();

        }

    }
}