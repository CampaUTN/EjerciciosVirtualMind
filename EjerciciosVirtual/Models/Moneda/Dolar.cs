using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

using System.Net.Http;
using System.IO;
using System.Text;

namespace EjerciciosVirtual.Models.Moneda
{
    public class Dolar : IMoneda
    {
        private const string url = "https://www.bancoprovincia.com.ar/Principal/Dolar";

        public HttpResponseMessage GetCotizacion()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            HttpResponseMessage message = new HttpResponseMessage(HttpStatusCode.OK);

            using (var responseApi = (HttpWebResponse)request.GetResponse())
            {
                using (var reader = new StreamReader(responseApi.GetResponseStream()))
                {
                    var objText = reader.ReadToEnd();
                    message.Content = new StringContent(objText, Encoding.UTF8, "application/json");
                }
            }
            return message;
        }
    }
}