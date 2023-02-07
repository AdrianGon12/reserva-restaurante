using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Cliente.Controllers
{
    public class TopUsuariosController : Controller
    {
        ProxyReserva.ServicioReservasClient srvReservas = new ProxyReserva.ServicioReservasClient();
        ProxyRestaurante.ServicioRestaurantesClient srvRestaurantes = new ProxyRestaurante.ServicioRestaurantesClient();

        // GET: TopUsuarios
        public ActionResult Index()
        {
            ViewBag.ListarReservas = srvReservas.GetTopUsuariosReservasRestaurante(1);
            ViewBag.ListarRestaurantes = ObtenerRestaurantes();
            return View();
        }

        public List<SelectListItem> ObtenerRestaurantes()
        {
            List<SelectListItem> items = new SelectList(srvRestaurantes.GetAllRestaurantesActivo(), "Id_Restaurante", "Nom_Restaurante").ToList();
            return items;
        }

        public ActionResult Buscar(FormCollection fc)
        {
            Int16 criterioRestaurante = Convert.ToInt16(fc["cboRestaurantes"]);

            ViewBag.ListarReservas = srvReservas.GetTopUsuariosReservasRestaurante(criterioRestaurante);
            ViewBag.ListarRestaurantes = ObtenerRestaurantes();

            return View("Index");
        }
    }
}