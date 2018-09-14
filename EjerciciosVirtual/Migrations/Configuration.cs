namespace EjerciciosVirtual.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EjerciciosVirtual.Models.Usuarios.UsuarioContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EjerciciosVirtual.Models.Usuarios.UsuarioContext";
        }

        protected override void Seed(EjerciciosVirtual.Models.Usuarios.UsuarioContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
