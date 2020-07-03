using Microsoft.EntityFrameworkCore;
using Models;

namespace DbRespositorie
{
    //Derived class from DbContext
    public class Context : DbContext
    {     
        /// <value> Get and Set properties of users  </value>
        public DbSet<UsuarioModels> Usuarios { get; set; }      

        /// <summary>
        /// Initializing DbContextOptions
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql("Server=localhost;User Id=root;Database=embutidos");
        }
    }
}