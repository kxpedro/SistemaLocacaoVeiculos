using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http.Results;

namespace SLV.Database
{
    public class Commands
    {
        private static string StringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pedro.sarmento\\Repository\\SistemaLocacaoVeiculos\\SLV\\SLV\\App_Data\\Database.mdf;Integrated Security=True";
        
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

        public static string SelectAll(string tabela)
        {
            var sqlCon = Conectar();

            SqlCommand cmd = new SqlCommand("SELECT * FROM " + tabela, sqlCon);
            DataTable dt = new DataTable(tabela);

            sqlCon.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            sqlCon.Close();

            var listCols = new List<DataColumn>();
            var listRows = new List<DataRow>();

            for (int c = 0; c < dt.Columns.Count; c++)
            {
                var col = dt.Columns[c];
                listCols.Add(col);
            }

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                var row = dt.Rows[r];
                listRows.Add(row);
            }            

            //List<Models.Veiculo> veiculoList = new List<Models.Veiculo>();

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> rc;

            foreach (DataRow r in dt.Rows)
            {
                rc = new Dictionary<string, object>();
                foreach (DataColumn c in dt.Columns)
                {                    
                    rc.Add(c.ColumnName, r[c]);
                }
                rows.Add(rc);
            }

            return JsonConvert.SerializeObject(rows);
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