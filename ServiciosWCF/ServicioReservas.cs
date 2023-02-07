using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace ServiciosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioReservas" en el código y en el archivo de configuración a la vez.
    public class ServicioReservas : IServicioReservas
    {
        public List<ReservaBE> GetAllReservasCliente(Int16 idUsua)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<ReservaBE> objListaReservas = new List<ReservaBE>();

            try
            {
                var query = MisReservas.usp_ListarReservas(idUsua);

                foreach (var resultado in query)
                {
                    ReservaBE objReserva = new ReservaBE();

                    objReserva.Id_Reserva = Convert.ToInt16(resultado.idReserva);
                    objReserva.Fecha_Reserva = Convert.ToDateTime(resultado.fechaReserva);
                    objReserva.Cant_Personas = Convert.ToInt16(resultado.cantPersonas);
                    objReserva.Id_Restaurante = Convert.ToInt16(resultado.idRestaurante);
                    objReserva.Nom_Restaurante = resultado.nomRestaurante;
                    objReserva.Direc_Restaurante = resultado.direcRestaurante;
                    objReserva.Nom_DistritoRestaurante = resultado.nomDistrito;
                    objReserva.Estado_Reserva = resultado.Estado;

                    objListaReservas.Add(objReserva);
                }

                return objListaReservas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ReservaBE> GetAllReservasPorDia(DateTime fecha)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<ReservaBE> objListaReservas = new List<ReservaBE>();

            try
            {
                var query = MisReservas.usp_ListarReservasPorDia(fecha);

                foreach (var resultado in query)
                {
                    ReservaBE objReserva = new ReservaBE();

                    objReserva.Id_Reserva = Convert.ToInt16(resultado.idReserva);
                    objReserva.Fecha_Reserva = Convert.ToDateTime(resultado.fechaReserva);
                    objReserva.Cant_Personas = Convert.ToInt16(resultado.cantPersonas);
                    objReserva.Id_Restaurante = Convert.ToInt16(resultado.idRestaurante);
                    objReserva.Nom_Restaurante = resultado.nomRestaurante;
                    objReserva.Direc_Restaurante = resultado.direcRestaurante;
                    objReserva.Nom_DistritoRestaurante = resultado.nomDistrito;
                    objReserva.Estado_Reserva = resultado.Estado;

                    objListaReservas.Add(objReserva);
                }

                return objListaReservas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ReservaBE> GetAllReservasPorDiaRestaurante(DateTime fecha, Int16 idResta)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<ReservaBE> objListaReservas = new List<ReservaBE>();

            try
            {
                var query = MisReservas.usp_ListarReservasPorDiaRestaurante(fecha, idResta);

                foreach (var resultado in query)
                {
                    ReservaBE objReserva = new ReservaBE();

                    objReserva.Id_Reserva = Convert.ToInt16(resultado.idReserva);
                    objReserva.Fecha_Reserva = Convert.ToDateTime(resultado.fechaReserva);
                    objReserva.Cant_Personas = Convert.ToInt16(resultado.cantPersonas);
                    objReserva.Id_Restaurante = Convert.ToInt16(resultado.idRestaurante);
                    objReserva.Nom_Restaurante = resultado.nomRestaurante;
                    objReserva.Direc_Restaurante = resultado.direcRestaurante;
                    objReserva.Nom_DistritoRestaurante = resultado.nomDistrito;
                    objReserva.Estado_Reserva = resultado.Estado;

                    objListaReservas.Add(objReserva);
                }

                return objListaReservas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertReserva(ReservaBE objReservaBE)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();

            try
            {
                MisReservas.usp_InsertarReserva(objReservaBE.Id_Usuario, objReservaBE.Id_Restaurante, objReservaBE.Fecha_Reserva, objReservaBE.Cant_Personas);

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean CancelReserva(Int16 idUsua, Int16 idReser)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();

            try
            {
                MisReservas.usp_CancelarReserva(idUsua, idReser);

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ReservaBE> GetAllReservasRestaurante(Int16 idResta)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<ReservaBE> objListaReservas = new List<ReservaBE>();

            try
            {
                var query = MisReservas.usp_ListarReservasRestaurantes(idResta);

                foreach (var resultado in query)
                {
                    ReservaBE objReserva = new ReservaBE();

                    objReserva.Id_Reserva = Convert.ToInt16(resultado.idReserva);
                    objReserva.Fecha_Reserva = Convert.ToDateTime(resultado.fechaReserva);
                    objReserva.Cant_Personas = Convert.ToInt16(resultado.cantPersonas);
                    objReserva.Id_Restaurante = Convert.ToInt16(resultado.idRestaurante);
                    objReserva.Nom_Restaurante = resultado.nomRestaurante;
                    objReserva.Direc_Restaurante = resultado.direcRestaurante;
                    objReserva.Nom_DistritoRestaurante = resultado.nomDistrito;
                    objReserva.Estado_Reserva = resultado.Estado;

                    objReserva.Usua_Dni = resultado.dniUsuario;
                    objReserva.Usua_Correo = resultado.correoUsuario;
                    objReserva.Usua_Nombre = resultado.nomUsuario;
                    objReserva.Usua_Apellido = resultado.apeUsuario;

                    objListaReservas.Add(objReserva);
                }

                return objListaReservas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateEstadoReserva(Int16 idUsua)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();

            try
            {
                MisReservas.usp_ActualizarReserva(idUsua);

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ReservaBE> GetTopUsuariosReservasRestaurante(Int16 idResta)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<ReservaBE> objListaReservas = new List<ReservaBE>();

            try
            {
                var query = MisReservas.usp_ListarTopUsuarioReservasPorRestaurante(idResta);

                foreach (var resultado in query)
                {
                    ReservaBE objReserva = new ReservaBE();

                    objReserva.Cant_Veces = Convert.ToInt16(resultado.Cant);
                    objReserva.Nom_Restaurante = resultado.nomRestaurante;
                    objReserva.Usua_Nombre = resultado.nomUsuario;
                    objReserva.Usua_Apellido = resultado.apeUsuario;

                    objListaReservas.Add(objReserva);
                }

                return objListaReservas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Int16 GetCantPersonasReservas(DateTime fecha, Int16 idResta)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();

            try
            {
                Int16 cant = Convert.ToInt16(MisReservas.usp_NumPersonasDiaReservasRestaurante(fecha, idResta).FirstOrDefault());

                return cant;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
