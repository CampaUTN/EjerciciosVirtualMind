using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjerciciosVirtual.Models.Moneda
{
    public static class InstanciadorMoneda
    {
        public static IMoneda GetTipoMoneda(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "dolar":
                    return new Dolar();
                case "pesos":
                    return new Pesos();
                case "real":
                    return new Real();
                default:
                    return null;
            }
        }
    }
}