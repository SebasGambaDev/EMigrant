using System;
using System.Collections.Generic;
using EMigrant2.Modelos;
using EMigrant2.Persistencia.Data;
using EMigrant2.Persistencia.Repositorios.IRepositorios;

namespace EMigrant2.Persistencia.Repositorios
{
    public class UsuarioMigranteRepositorio : IUsuarioMigranteRepositorio
    {
        private readonly EMigrant2Context _db;

        IEnumerable<UsuarioMigrante> usuariosMigrantes { get; set; }

        public UsuarioMigranteRepositorio(EMigrant2Context db)  
        {
           _db = db;
        }

        public void AgregarUsuarioMigrante(UsuarioMigrante usuarioMigrante)
        {
            _db.UsuariosMigrantes.Add(usuarioMigrante);
            _db.SaveChanges();

            
        }

        
    }
}
