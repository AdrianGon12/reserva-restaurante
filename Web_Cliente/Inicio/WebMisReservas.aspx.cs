using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Cliente.Inicio
{

    public partial class WebMisReservas : System.Web.UI.Page
    {
        ProxyReserva.ServicioReservasClient srvReservas = new ProxyReserva.ServicioReservasClient();

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
            Int16 id = Convert.ToInt16(Session["idUsuario"]);
            srvReservas.UpdateEstadoReserva(id);

            grvReservas.DataSource = srvReservas.GetAllReservasCliente(id);
            grvReservas.DataBind();
        }

        protected void grvReservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow fila = grvReservas.SelectedRow;
            String estado = fila.Cells[5].Text;

            if (estado == "Finalizada")
            {
                Session["idRestauranteReseña"] = fila.Cells[1].Text;
                Response.Redirect("~/Inicio/WebEscribirReseña.aspx");
            }
            else
            {
                Response.Write("<script> alert(" + "'No se puede escribir una reseña en esta reserva'" + ") </script>");
            }
            
        }
    }
}