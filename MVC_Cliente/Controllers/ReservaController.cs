using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Cliente.Controllers
{
    public class ReservaController : Controller
    {
        ProxyReserva.ServicioReservasClient srvReservas = new ProxyReserva.ServicioReservasClient();
        ProxyRestaurante.ServicioRestaurantesClient srvRestaurantes = new ProxyRestaurante.ServicioRestaurantesClient();

        // GET: Reserva
        public ActionResult Index()
        {
            ViewBag.ListarReservas = srvReservas.GetAllReservasPorDia(DateTime.Today);
            ViewBag.ListarRestaurantes = ObtenerRestaurantes();
            return View();
        }

        public List<SelectListItem> ObtenerRestaurantes()
        {
            List<SelectListItem> items = new SelectList(srvRestaurantes.GetAllRestaurantesActivo(), "Id_Restaurante", "Nom_Restaurante").ToList();
            items.Insert(0, (new SelectListItem { Text = "Seleccione Restaurante", Value = "0" }));
            return items;
        }

        public ActionResult Buscar(FormCollection fc)
        {
            DateTime criterio = Convert.ToDateTime(fc["criterio"]);
            Int16 criterioRestaurante = Convert.ToInt16(fc["cboRestaurantes"]);

            if (criterio != null && criterioRestaurante != 0)
            {
                ViewBag.ListarReservas = srvReservas.GetAllReservasPorDiaRestaurante(criterio, criterioRestaurante);
            }
            else
            {
                ViewBag.ListarReservas = srvReservas.GetAllReservasPorDia(criterio);
            }

            ViewBag.ListarRestaurantes = ObtenerRestaurantes();

            return View("Index");
        }
    }
}