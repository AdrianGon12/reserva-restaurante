using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Cliente.Controllers
{
    public class RestauranteController : Controller
    {
        ProxyRestaurante.ServicioRestaurantesClient srvRestaurantes = new ProxyRestaurante.ServicioRestaurantesClient();

        // GET: Restaurante
        public ActionResult Index()
        {
            ViewBag.ListarRestaurantes = srvRestaurantes.GetAllRestaurantesActivo();
            ViewBag.ListarDistritos = ObtenerDistritos();
            ViewBag.ListarCategorias = ObtenerCategorias();
            return View();
        }

        public List<SelectListItem> ObtenerDistritos()
        {
            List<SelectListItem> items = new SelectList(srvRestaurantes.GetAllDistritos(), "Distri_Restaurante", "Nom_DistritoRestaurante").ToList();
            items.Insert(0, (new SelectListItem { Text = "Seleccione Distrito", Value = "0" }));
            return items;
        }

        public List<SelectListItem> ObtenerCategorias()
        {
            List<SelectListItem> items = new SelectList(srvRestaurantes.GetAllCategorias(), "Cate_Restaurante", "Nom_CategoriaRestaurante").ToList();
            items.Insert(0, (new SelectListItem { Text = "Seleccione Categoria", Value = "0" }));
            return items;
        }

        public ActionResult Buscar(FormCollection fc)
        {
            // Se toman los valores desde el formulario en la vista
            Int16 criterioDistrito = Convert.ToInt16(fc["cboDitritos"]);
            Int16 criterioCategoria = Convert.ToInt16(fc["cboCategorias"]);


            if (criterioDistrito != 0 && criterioCategoria != 0)
            {
                ViewBag.ListarRestaurantes = srvRestaurantes.GetAllRestaurantesPorCategoriaDistrito(criterioCategoria, criterioDistrito);
            }
            else if (criterioDistrito != 0)
            {
                ViewBag.ListarRestaurantes = srvRestaurantes.GetAllRestaurantesPorDistrito(criterioDistrito);
            }
            else if (criterioCategoria != 0)
            {
                ViewBag.ListarRestaurantes = srvRestaurantes.GetAllRestaurantesPorCategoria(criterioCategoria);
            }
            else
            {
                ViewBag.ListarRestaurantes = srvRestaurantes.GetAllRestaurantesActivo();
            }

            
            ViewBag.ListarDistritos = ObtenerDistritos();
            ViewBag.ListarCategorias = ObtenerCategorias();

            return View("Index");
        }
    }
}