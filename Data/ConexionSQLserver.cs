using ApiCandataCUN.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCandataCUN.Data
{
    public class ConexionSQLserver : DbContext
    {
        public ConexionSQLserver(DbContextOptions<ConexionSQLserver> options) : base(options) 
        { 
            //
        
        }

        // DbSet para cada entidad
        public DbSet<Candidato> Pruebas { get; set; }
    }
}
