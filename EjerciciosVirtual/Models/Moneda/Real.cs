using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace EjerciciosVirtual.Models.Moneda
{
    public class Real : IMoneda
    {
        public HttpResponseMessage GetCotizacion()
        {
            return new HttpResponseMessage(HttpStatusCode.Unauthorized);
        }
    }
}