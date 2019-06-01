using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SLV.Database
{
    public class Connection
    {

        private static string StringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pedro.sarmento\\Repository\\SistemaLocacaoVeiculos\\SLV\\SLV\\App_Data\\Database.mdf;Integrated Security=True";      

        public static SqlConnection Conectar()
        {            
            SqlConnection sqlConn = new SqlConnection(StringConnection);
            return sqlConn;
        }

    }
}