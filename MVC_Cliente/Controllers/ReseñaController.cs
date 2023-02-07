using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Cliente.Controllers
{
    public class ReseñaController : Controller
    {
        ProxyResena.ServicioResenasClient srvReseñas = new ProxyResena.ServicioResenasClient();
        ProxyRestaurante.ServicioRestaurantesClient srvRestaurantes = new ProxyRestaurante.ServicioRestaurantesClient();

        // GET: Reseña
        public ActionResult Index()
        {
            ViewBag.ListarReseñas = srvReseñas.GetAllReseñas();
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
            // Se toman los valores desde el formulario en la vista
            Int16 criterioRestaurante = Convert.ToInt16(fc["cboRestaurantes"]);


            if (criterioRestaurante != 0)
            {
                ViewBag.ListarReseñas = srvReseñas.GetAllReseñasRestaurante(criterioRestaurante);
            }
            else
            {
                ViewBag.ListarReseñas = srvReseñas.GetAllReseñas();
            }

            ViewBag.ListarRestaurantes = ObtenerRestaurantes();

            return View("Index");
        }
    }
}