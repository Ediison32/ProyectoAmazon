using Microsoft.EntityFrameworkCore;

using proyectoAmazon.App.Dominio;
 
namespace ProyectoAmazon.App.Persistencia
{
    public class AppContext: DbContext{   // conexion o creacion base de datos 
        public DbSet<Encomienda> Encomienda { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Servicio> Servicio { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){ // crar conexion bse de datos 
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProyectoAmazon"); // toca cambiar la ubicacion .. 
            }
        }
    }
}



// parados en terminal proyectoAmazon.App.Persistencia 
// aplicamos el siguiente comando 
//   dotnet add reference ..\ProyectoAmazon.App.Dominio\
// para que nos genere una comunicacion y se agregue la referencia
