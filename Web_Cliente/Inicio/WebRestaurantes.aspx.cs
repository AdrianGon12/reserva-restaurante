using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Cliente.Inicio
{
    public partial class WebRestaurantes : System.Web.UI.Page
    {
        ProxyRestaurante.ServicioRestaurantesClient srvRestaurantes = new ProxyRestaurante.ServicioRestaurantesClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            VerificarSesion();

            if (!Page.IsPostBack)
            {
                Listar();
            }
            
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
            grvRestaurantes.DataSource = srvRestaurantes.GetAllRestaurantesActivo();
            grvRestaurantes.DataBind();
        }

        protected void grvRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow fila = grvRestaurantes.SelectedRow;
            Session["idRestaurante"] = fila.Cells[0].Text;
            Response.Redirect("~/Inicio/WebReservar.aspx");
        }
    }
}