using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMigrant2.Modelos;
using EMigrant2.Persistencia.Repositorios.IRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMigrant2.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsuarioMigranteRepositorio usuarioMigranteRepositorio;


        [BindProperty]
        public UsuarioMigrante UsuarioMigrante { get; set; }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Create(UsuarioMigrante usuarioMigrante)
        
        {
            try
            {
                if (ModelState.IsValid)
                {
                    usuarioMigranteRepositorio.AgregarUsuarioMigrante(usuarioMigrante);
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(usuarioMigrante);
        }
    }
}