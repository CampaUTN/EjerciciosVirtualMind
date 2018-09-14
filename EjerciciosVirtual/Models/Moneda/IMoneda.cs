using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosVirtual.Models.Moneda
{
    public interface IMoneda
    {
        HttpResponseMessage GetCotizacion();
    }
}
