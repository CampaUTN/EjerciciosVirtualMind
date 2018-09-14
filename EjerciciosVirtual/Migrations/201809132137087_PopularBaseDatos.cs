namespace EjerciciosVirtual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopularBaseDatos : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Usuarios (Nombre, Apellido, Mail, Password) values ('Rodrigo', 'Campassi', 'rodrigocampassi@gmail.com', 'callefalsa123')");
            Sql("INSERT INTO Usuarios (Nombre, Apellido, Mail, Password) values ('Juan', 'Perez', 'jperez@gmail.com', 'jp123')");
            Sql("INSERT INTO Usuarios (Nombre, Apellido, Mail, Password) values ('Maria', 'Fernandez', 'mfernandez@gmail.com', 'mf123')");
            Sql("INSERT INTO Usuarios (Nombre, Apellido, Mail, Password) values ('Pedro', 'Roble', 'proble@gmail.com', 'pr123')");
            Sql("INSERT INTO Usuarios (Nombre, Apellido, Mail, Password) values ('Lucia', 'Rodriguez', 'lrodriguez@gmail.com', 'lr123')");

        }

        public override void Down()
        {
        }
    }
}
