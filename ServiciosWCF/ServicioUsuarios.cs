using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace ServiciosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuarios" en el código y en el archivo de configuración a la vez.
    public class ServicioUsuarios : IServicioUsuarios
    {
        public UsuarioBE GetUsuario(String correo)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();

            try
            {
                Usuario objUsuario = (from miUsuario in MisReservas.Usuario 
                                      where miUsuario.correoUsuario == correo
                                      select miUsuario).FirstOrDefault();

                UsuarioBE objUsuarioBE = new UsuarioBE();

                if (objUsuario == null)
                {
                    objUsuarioBE = null;
                }
                else
                {
                    objUsuarioBE.Id_Usuario = Convert.ToInt16(objUsuario.idUsuario);
                    objUsuarioBE.Correo_Usuario = objUsuario.correoUsuario;
                    objUsuarioBE.Contra_Usuario = objUsuario.contraUsuario;
                    objUsuarioBE.Dni_Usuario = objUsuario.dniUsuario;
                    objUsuarioBE.Nom_Usuario = objUsuario.nomUsuario;
                    objUsuarioBE.Ape_Usuario = objUsuario.apeUsuario;
                    objUsuarioBE.Tele_Usuario = objUsuario.teleUsuario;
                    objUsuarioBE.Naci_Usuario = Convert.ToDateTime(objUsuario.naciUsuario);
                    objUsuarioBE.Nivel_Usuario = Convert.ToInt16(objUsuario.nivelUsuario);
                    objUsuarioBE.FecRegistro_Usuario = Convert.ToDateTime(objUsuario.fecRegistroUsurio);
                }
                

                return objUsuarioBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
