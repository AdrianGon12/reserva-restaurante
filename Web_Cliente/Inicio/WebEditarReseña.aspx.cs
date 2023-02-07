using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Cliente.Inicio
{
    public partial class WebEditarReseña : System.Web.UI.Page
    {
        ProxyResena.ServicioResenasClient srvReseñas = new ProxyResena.ServicioResenasClient();
        ServiciosWCF.ReseñaBE objReseña = new ServiciosWCF.ReseñaBE();
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
            Int16 id = Convert.ToInt16(Session["idReseña"]);
            objReseña = srvReseñas.GetReseña(id);

            txtTitulo.Text = objReseña.Titulo_Reseña;
            txtContenido.Text = objReseña.Contenido_Reseña;
        }

        protected void btnEditarReseña_Click(object sender, EventArgs e)
        {
            Int16 id = Convert.ToInt16(Session["idReseña"]);
            ServiciosWCF.ReseñaBE objReseña1 = new ServiciosWCF.ReseñaBE();
            objReseña1.Titulo_Reseña = txtTitulo.Text;
            objReseña1.Contenido_Reseña = txtContenido.Text;

            Boolean res = srvReseñas.UpdateReseña(objReseña1, id);

            if (res)
            {
                Response.Redirect("~/Inicio/WebMisReseñas.aspx");
            }
        }
    }
}