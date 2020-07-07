using Microsoft.EntityFrameworkCore;
using Models;

namespace DbRespositorie
{
    // Deriva da Classe Classe DBbContext
    public class Context : DbContext
    {
        // Get E Set das propriedades do Usuário
        public DbSet<UsuarioModels> Usuarios { get; set; }


        // Initializando DbContextOptions
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql("Server=localhost;User Id=root;Database=embutidos");
        }
    }
}