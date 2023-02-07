using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Cliente.Login
{
    public partial class WebLogin : System.Web.UI.Page
    {
        ProxyUsuario.ServicioUsuariosClient srvUsuario = new ProxyUsuario.ServicioUsuariosClient();
        ServiciosWCF.UsuarioBE objUsuario = new ServiciosWCF.UsuarioBE();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "" || txtClave.Text == "")
            {
                Response.Write("<script> alert(" + "'Datos incompletos'" + ") </script>");
            }
            else
            {
                String correo = txtCorreo.Text;
                String clave = txtClave.Text;

                objUsuario = srvUsuario.GetUsuario(correo);

                if (objUsuario == null)
                {
                    Response.Write("<script> alert(" + "'Correo incorrecto'" + ") </script>");
                }
                else
                {
                    if (clave == objUsuario.Contra_Usuario)
                    {
                        Session["idUsuario"] = objUsuario.Id_Usuario;
                        Response.Redirect("~/Inicio/WebRestaurantes.aspx");
                    }
                    else
                    {
                        Response.Write("<script> alert(" + "'Contraseña incorrecta'" + ") </script>");
                    }
                }
            }
                
            
        }
    }
}