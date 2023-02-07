using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Cliente.Inicio
{
    public partial class WebMisReseñas : System.Web.UI.Page
    {
        ProxyResena.ServicioResenasClient srvReseñas = new ProxyResena.ServicioResenasClient();

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
            grvReseñas.DataSource = srvReseñas.GetAllReseñasUsuario(id);
            grvReseñas.DataBind();
        }

        protected void grvReseñas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow fila = grvReseñas.SelectedRow;
            Session["idReseña"] = fila.Cells[0].Text;
            Response.Redirect("~/Inicio/WebEditarReseña.aspx");
        }
    }
}