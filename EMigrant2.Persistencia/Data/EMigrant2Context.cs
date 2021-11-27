using System;
using EMigrant2.Modelos;
using Microsoft.EntityFrameworkCore;

namespace EMigrant2.Persistencia.Data
{
    public class EMigrant2Context : DbContext
    {
        public EMigrant2Context()
        {
        }

        public EMigrant2Context(DbContextOptions<EMigrant2Context> options) : base(options)
        {
        }

        public DbSet<UsuarioMigrante> UsuariosMigrantes { get; set; }
    }
}
