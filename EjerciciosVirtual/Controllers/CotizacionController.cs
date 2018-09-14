using EjerciciosVirtual.Models.Moneda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EjerciciosVirtual.Controllers
{
    public class CotizacionController : ApiController
    {
        //GET EjerciciosVirtual/Cotizacion/{moneda}
        public HttpResponseMessage Get(string id)
        {
            IMoneda Moneda = InstanciadorMoneda.GetTipoMoneda(id);

            return Moneda.GetCotizacion();
        }
    }
}
