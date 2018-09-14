using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using EjerciciosVirtual.Models.Moneda;

namespace EjerciciosVirtual.Tests
{
    [TestClass]
    class TestMoneda
    {
        [TestMethod]
        public void testDolar()
        {
            Dolar d = new Dolar();
            Assert.IsTrue(HttpStatusCode.OK == d.GetCotizacion().StatusCode);
        }

        [TestMethod]
        public void testPesos()
        {
            Pesos p = new Pesos();
            Assert.IsTrue(HttpStatusCode.Unauthorized == p.GetCotizacion().StatusCode);
        }

        [TestMethod]
        public void testReal()
        {
            Real r = new Real();
            Assert.IsTrue(HttpStatusCode.Unauthorized == r.GetCotizacion().StatusCode);
        }
    }
}
