using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LocacaoVeiculos.Models
{
    public class Database
    {
        public static SqlConnection StringConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=P:\\Repository\\SistemaLocacaoVeiculos\\LocacaoVeiculos\\LocacaoVeiculos\\App_Data\\Database1.mdf;Integrated Security=True");                    
        
        public static void Insert(Veiculo v)
        {            
            string values = "('"+v.Marca+"','" + v.Modelo + "','" + v.Placa + "'," + v.ValorFipe + "," + v.ValorLocacao + ",'" + v.AnoFabricacao.ToString("MM/dd/yyyy HH:mm:ss") + "','" + v.UltimaRevisao.ToString("MM/dd/yyyy HH:mm:ss") + "')";
            SqlCommand cmd = new SqlCommand("INSERT INTO Veiculo VALUES " + values, StringConnection);
            StringConnection.Close();
            StringConnection.Open();
            cmd.ExecuteNonQuery();
            StringConnection.Close();
        }

        //public static void Update(int idVeiculo, Veiculo v)
        //{
        //    SqlCommand cmd = new SqlCommand("UPDATE Veiculo WHERE Id = " + idVeiculo + "SET ", StringConnection);
        //    StringConnection.Open();
        //    cmd.ExecuteNonQuery();
        //    StringConnection.Close();
        //}

        public static void Delete(int idVeiculo, Veiculo v)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Veiculo WHERE Id = " + idVeiculo, StringConnection);
            StringConnection.Close();
            StringConnection.Open();
            cmd.ExecuteNonQuery();
            StringConnection.Close();
        }

        public static List<Veiculo> Select()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Veiculo", StringConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            StringConnection.Close();
            StringConnection.Open();            
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(ds);
            StringConnection.Close();

            var tableList = new List<Veiculo> { };
            int numRows;
            numRows = ds.Tables["Table"].Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                int id = ds.Tables["Table"].Rows[i].Field<int>("Id");
                string marca = ds.Tables["Table"].Rows[i].Field<string>("Marca");
                string modelo = ds.Tables["Table"].Rows[i].Field<string>("Modelo");
                string placa = ds.Tables["Table"].Rows[i].Field<string>("Placa");
                decimal valorFipe = ds.Tables["Table"].Rows[i].Field<decimal>("ValorFipe");
                decimal valorLocacao = ds.Tables["Table"].Rows[i].Field<decimal>("ValorLocacao");
                DateTime anoFabricacao = ds.Tables["Table"].Rows[i].Field<DateTime>("AnoFabricacao");
                DateTime ultimaRevisao = ds.Tables["Table"].Rows[i].Field<DateTime>("UltimaRevisao");

                tableList.Add(new Veiculo()
                {
                    Id = id,
                    Marca = marca,
                    Modelo = modelo,
                    Placa = placa,
                    ValorFipe = valorFipe,
                    ValorLocacao = valorLocacao,
                    AnoFabricacao = anoFabricacao,
                    UltimaRevisao = ultimaRevisao
                });
            }

            return tableList;
        }

        public static Veiculo Details(int idVeiculo)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Veiculo WHERE Id = " + idVeiculo, StringConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            StringConnection.Close();
            StringConnection.Open();
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(ds);
            StringConnection.Close();

            var tableList = new List<Veiculo> { };

            int id = ds.Tables["Table"].Rows[0].Field<int>("Id");
            string marca = ds.Tables["Table"].Rows[0].Field<string>("Marca");
            string modelo = ds.Tables["Table"].Rows[0].Field<string>("Modelo");
            string placa = ds.Tables["Table"].Rows[0].Field<string>("Placa");
            decimal valorFipe = ds.Tables["Table"].Rows[0].Field<decimal>("ValorFipe");
            decimal valorLocacao = ds.Tables["Table"].Rows[0].Field<decimal>("ValorLocacao");
            DateTime anoFabricacao = ds.Tables["Table"].Rows[0].Field<DateTime>("AnoFabricacao");
            DateTime ultimaRevisao = ds.Tables["Table"].Rows[0].Field<DateTime>("UltimaRevisao");

            tableList.Add(new Veiculo()
            {
                Id = id,
                Marca = marca,
                Modelo = modelo,
                Placa = placa,
                ValorFipe = valorFipe,
                ValorLocacao = valorLocacao,
                AnoFabricacao = anoFabricacao,
                UltimaRevisao = ultimaRevisao
            });
            
            return tableList.FirstOrDefault(); ;
        }

    }
}