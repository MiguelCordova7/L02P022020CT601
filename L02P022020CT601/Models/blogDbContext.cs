using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace L02P022020CT601.Models
{
    public class blogDbContext : DbContext
    {
        public blogDbContext(DbContextOptions<blogDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<calificaciones> calificaciones { get; set; }

        public DbSet<comentarios> comentarios { get; set; }

        public DbSet<publicaciones> publicaciones { get; set;}

        public DbSet<usuarios> usuarios { get; set; }
    }
}
