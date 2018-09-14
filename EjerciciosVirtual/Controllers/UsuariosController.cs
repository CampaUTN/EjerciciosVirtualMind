using EjerciciosVirtual.Models.Moneda;
using EjerciciosVirtual.Models.Usuarios;
using EjerciciosVirtual.Providers;
using EjerciciosVirtual.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace EjerciciosVirtual.Controllers
{
    public class UsuariosController : ApiController
    {
        private ServicioPersistenciaUsuarios spu = new ServicioPersistenciaUsuarios(); //Se delega el comportamiento en el servicio para que sea mas mantenible, extensible y testeable

        //GET EjerciciosVirtual/Usuarios
        public string[] Get()
        {
            return spu.Get();
        }

        //GET EjerciciosVirtual/Usuarios/1
        public string Get(int id)
        {
            return spu.Get(id);
        }

        //PUT EjerciciosVirtual/Usuarios
        public string Put([FromBody]Usuario user)
        {
            return spu.Put(user);
        }

        //POST EjerciciosVirtual/Usuarios
        public void Post([FromBody]Usuario user)
        {
            spu.Post(user);
        }

        //DELETE EjerciciosVirtual/Usuarios/4
        public string Delete(int id)
        {
            return spu.Delete(id);
        }

    }
}
