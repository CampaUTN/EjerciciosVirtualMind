using EjerciciosVirtual.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EjerciciosVirtual.Services
{
    public class ServicioPersistenciaUsuarios //Se delega el comportamiento en el servicio para que sea mas mantenible en caso de querer cambiar la forma de persistencia y ademas sea mas testeable
    {

        private UsuarioContext db = new UsuarioContext();

        public string[] Get()
        {
            List<string> lista = new List<string>();

            using (var db = new UsuarioContext())
            {
                foreach (Usuario u in db.Usuarios)
                    lista.Add(string.Format("Usuario: {0} - {1} {2} - {3} {4}", u.Id, u.Nombre, u.Apellido, u.Mail, u.Password) + Environment.NewLine);
            }

            return lista.ToArray();
        }

        public string Get(int id)
        {
            return UserString(db.Usuarios.Find(id));
        }

        public string Put(Usuario user)
        {
            db.Entry(user).State = EntityState.Modified;

            if (db.Usuarios.Any(x => x.Id == user.Id))
            {
                db.SaveChanges();
                return "Se actualizo correctamente el registro" + user.Id;
            }
            else
            {
                throw new Exception("No encontrado");
            }
        }

        public void Post(Usuario user)
        {
            db.Usuarios.Add(user);
            db.SaveChanges();
        }

        public string Delete(int id)
        {
            Usuario user = db.Usuarios.Find(id);
            if (user != null)
            {
                db.Usuarios.Remove(user);
                db.SaveChanges();

                return "Se elimino correctamente el registro" + id;
            }
            else
            {
                throw new Exception("No encontrado");
            }
        }

        // Metodos Auxiliares

        public string UserString(Usuario u)
        {
            return string.Format("Usuario: {0} - {1} {2} - {3} {4}", u.Id, u.Nombre, u.Apellido, u.Mail, u.Password) + Environment.NewLine;
        }

        private bool UserExists(int id)
        {
            return db.Usuarios.Count(e => e.Id == id) > 0;
        }


    }
}