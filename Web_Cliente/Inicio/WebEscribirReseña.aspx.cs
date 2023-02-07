using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Cliente.Inicio
{
    public partial class WebEscribirReseña : System.Web.UI.Page
    {
        ProxyResena.ServicioResenasClient srvReseñas = new ProxyResena.ServicioResenasClient();
        ServiciosWCF.ReseñaBE objReseña = new ServiciosWCF.ReseñaBE();
        ProxyRestaurante.ServicioRestaurantesClient srvRestaurantes = new ProxyRestaurante.ServicioRestaurantesClient();
        ServiciosWCF.RestauranteBE objRestaurante = new ServiciosWCF.RestauranteBE();

        protected void Page_Load(object sender, EventArgs e)
        {
            VerificarSesion();
            Listar();
        }

        private void VerificarSesion()
        {
            if (Session["idUsuario"] == null)
            {
                Response.Redirect("~/WebInicio.aspx");
            }
        }

        private void Listar()
        {
            Int16 idResta = Convert.ToInt16(Session["idRestauranteReseña"]);
            objRestaurante = srvRestaurantes.GetRestaurante(idResta);
            txtRestaurante.Text = objRestaurante.Nom_Restaurante;
        }

        protected void btnEscribirReseña_Click(object sender, EventArgs e)
        {
            Int16 idResta = Convert.ToInt16(Session["idRestauranteReseña"]);
            Int16 idUsua = Convert.ToInt16(Session["idUsuario"]);
            objReseña.Titulo_Reseña = txtTitulo.Text;
            objReseña.Contenido_Reseña = txtContenido.Text;

            Boolean res = srvReseñas.InsertReseña(objReseña, idUsua, idResta);

            if (res)
            {
                Response.Redirect("~/Inicio/WebMisReseñas.aspx");
            }
        }
    }
}