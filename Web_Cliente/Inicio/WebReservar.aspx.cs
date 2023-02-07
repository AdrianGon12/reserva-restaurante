using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Cliente.Inicio
{
    public partial class WebReservar : System.Web.UI.Page
    {
        ProxyRestaurante.ServicioRestaurantesClient srvRestaurantes = new ProxyRestaurante.ServicioRestaurantesClient();
        ServiciosWCF.RestauranteBE objRestaurante = new ServiciosWCF.RestauranteBE();
        ProxyReserva.ServicioReservasClient srvReservas = new ProxyReserva.ServicioReservasClient();
        ServiciosWCF.ReservaBE objReserva = new ServiciosWCF.ReservaBE();

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
            Int16 id = Convert.ToInt16(Session["idRestaurante"]);
            objRestaurante = srvRestaurantes.GetRestaurante(id);

            txtNomRestaurante.Text = objRestaurante.Nom_Restaurante;
            txtDirecRestaurante.Text = objRestaurante.Direc_Restaurante;
        }

        protected void btnReservar_Click(object sender, EventArgs e)
        {
            if (txtHora.Text == "" || txtPersonas.Text == "")
            {
                Response.Write("<script> alert(" + "'Campos vacios'" + ") </script>");
            }
            else
            {
                String año = calFecha.SelectedDate.Year.ToString();
                String mes = calFecha.SelectedDate.Month.ToString();
                String dia = calFecha.SelectedDate.Day.ToString();
                String hora = txtHora.Text;
                DateTime fecha = Convert.ToDateTime(año + "-" + mes + "-" + dia + " " + hora);
                DateTime hoy = DateTime.Now;
                double dif = (fecha - hoy).TotalDays;

                if (dif < 0)
                {
                    Response.Write("<script> alert(" + "'Fecha no válida'" + ") </script>");
                }
                else
                {
                    Int16 personas = srvReservas.GetCantPersonasReservas(fecha, Convert.ToInt16(Session["idRestaurante"]));
                    if (personas + Convert.ToInt16(txtPersonas.Text) > 10)
                    {
                        Response.Write("<script> alert(" + "'Disponibilidad agotada'" + ") </script>");
                    }
                    else
                    {
                        objReserva.Id_Usuario = Convert.ToInt16(Session["idUsuario"]);
                        objReserva.Id_Restaurante = Convert.ToInt16(Session["idRestaurante"]);
                        objReserva.Fecha_Reserva = fecha;
                        objReserva.Cant_Personas = Convert.ToInt16(txtPersonas.Text);

                        Boolean res = srvReservas.InsertReserva(objReserva);

                        if (res)
                        {
                            Response.Redirect("~/Inicio/WebMisReservas.aspx");
                        }
                    }
                    
                }
                
                
            }

            
        }
    }
}