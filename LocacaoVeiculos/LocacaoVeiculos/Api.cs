using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace LocacaoVeiculos
{
    public class Api
    {
        private static string Url = "http://10.200.118.60:8081/carros";

        public static string DadosRequisicao()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(Url);
                return json;
            }
            
        }

    }
}