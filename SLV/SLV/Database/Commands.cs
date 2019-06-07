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

            SqlCommand cmd = new SqlCommand("INSERT INTO "+ tabela +" VALUES ("+ values + ")", sqlCon);

            sqlCon.Open();
            cmd.ExecuteNonQuery();
            sqlCon.Close();            
        }

        public static void DeleteAll<T>(T tabela, T campo, T value, T operador)
        {
            var sqlCon = Conectar();

            SqlCommand cmd = new SqlCommand("DELETE FROM " + tabela + " WHERE " + campo + operador + value, sqlCon);

            sqlCon.Open();
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        public static void DeleteWhere<T>(T tabela, T campo, T value, T operador)
        {
            var sqlCon = Conectar();

            SqlCommand cmd = new SqlCommand("DELETE FROM " + tabela + " WHERE " + campo + operador + value, sqlCon);

            sqlCon.Open();
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        public static DataTable SelectAll<T>(T tabela)
        {
            var sqlCon = Conectar();

            SqlCommand cmd = new SqlCommand("SELECT * FROM " + tabela, sqlCon);
            DataTable dt = new DataTable();

            sqlCon.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            sqlCon.Close();

            return dt;
        }

        public static DataTable SelectWhere<T>(T tabela, T campo, T value, T operador)
        {
            var sqlCon = Conectar();

            SqlCommand cmd = new SqlCommand("SELECT * FROM " + tabela + " WHERE " + campo + operador + value, sqlCon);
            DataTable dt = new DataTable();

            sqlCon.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            sqlCon.Close();

            return dt;
        }

    }
}