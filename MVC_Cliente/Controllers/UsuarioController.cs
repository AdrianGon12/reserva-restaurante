using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Cliente.Controllers
{
    public class UsuarioController : Controller
    {
        ProxyUsuarios.ServicioUsuariosClient miservUsuarios = new ProxyUsuarios.ServicioUsuariosClient();
        ProxyUsuarios.UsuarioBE objUsuario = new ProxyUsuarios.UsuarioBE();

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ingresar(FormCollection fc)
        {
            
           

            return Index();
        }
    }
}