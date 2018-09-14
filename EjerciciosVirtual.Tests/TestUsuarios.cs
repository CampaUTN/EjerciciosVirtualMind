using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using EjerciciosVirtual.Models.Moneda;
using EjerciciosVirtual.Services;
using EjerciciosVirtual.Models.Usuarios;

namespace EjerciciosVirtual.Tests
{
    [TestClass]
    class TestUsuarios
    {
        private ServicioPersistenciaUsuarios spu = new ServicioPersistenciaUsuarios();

        [TestMethod]
        public void testGet()
        {
            int cantidadOriginal = spu.Get().Length;

            Usuario u = new Usuario();
            u.Nombre = "NomTest";
            u.Apellido = "ApeTest";
            u.Mail = "mail@mail.com";
            u.Password = "pass";

            spu.Post(u);

            int cantidadPosterior = spu.Get().Length;

            Assert.IsTrue(cantidadOriginal == cantidadPosterior+1);
        }

    }
}
