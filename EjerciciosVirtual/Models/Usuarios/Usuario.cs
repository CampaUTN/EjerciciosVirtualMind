using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EjerciciosVirtual.Models.Usuarios
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }

    internal class UsuarioContext : DbContext
    {
        public UsuarioContext()
            : base("Usuarios")
        {
            Database.SetInitializer<UsuarioContext>(new CreateDatabaseIfNotExists<UsuarioContext>());
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}