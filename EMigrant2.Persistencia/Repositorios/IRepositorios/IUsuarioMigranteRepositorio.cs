using System;
using EMigrant2.Modelos;
using EMigrant2.Persistencia.Data;

namespace EMigrant2.Persistencia.Repositorios.IRepositorios
{
    public interface IUsuarioMigranteRepositorio
    {
        
        public void AgregarUsuarioMigrante(UsuarioMigrante usuarioMigrante);

    }
}
