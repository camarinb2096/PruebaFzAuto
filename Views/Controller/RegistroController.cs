using AppAcceso.Models;
using AppAcceso.Services;
using Microsoft.AspNetCore.Mvc;


namespace AppAcceso.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UserService _usuarioService = new UserService();

        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
    public ActionResult Registro(Usuario usuario)
    {
    if (ModelState.IsValid)
    {
        _usuarioService.CrearUsuario(usuario);
        return RedirectToAction("RegistroExitoso");
    }
    return View(usuario);
    }
   public ActionResult RegistroExitoso()
    {
        return View();
    }

        //internal void Mostrar()
        //{
          //  throw new NotImplementedException();
        //}
    }
}