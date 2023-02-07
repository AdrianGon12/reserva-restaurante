using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace ServiciosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioReseñas" en el código y en el archivo de configuración a la vez.
    public class ServicioResenas : IServicioResenas
    {
        public List<ReseñaBE> GetAllReseñas()
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<ReseñaBE> objListaReseñas = new List<ReseñaBE>();

            try
            {
                var query = MisReservas.usp_ListarTodasReseñas();

                foreach (var resultado in query)
                {
                    ReseñaBE objReseña = new ReseñaBE();

                    objReseña.Id_Reseña = Convert.ToInt16(resultado.idReseña);
                    objReseña.Id_Usuario = Convert.ToInt16(resultado.idUsuario);
                    objReseña.Id_Restaurante = Convert.ToInt16(resultado.idRestaurante);
                    objReseña.Titulo_Reseña = resultado.tituloReseña;
                    objReseña.Contenido_Reseña = resultado.contenidoReseña;
                    objReseña.Fecha_RegistroReseña = Convert.ToDateTime(resultado.Fecha);
                    objReseña.Nom_Restaurante = resultado.nomRestaurante;

                    objListaReseñas.Add(objReseña);
                }

                return objListaReseñas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ReseñaBE> GetAllReseñasRestaurante(Int16 idResta)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<ReseñaBE> objListaReseñas = new List<ReseñaBE>();

            try
            {
                var query = MisReservas.usp_ListarReseña(idResta);

                foreach (var resultado in query)
                {
                    ReseñaBE objReseña = new ReseñaBE();

                    objReseña.Id_Reseña = Convert.ToInt16(resultado.idReseña);
                    objReseña.Id_Usuario = Convert.ToInt16(resultado.idUsuario);
                    objReseña.Id_Restaurante = Convert.ToInt16(resultado.idRestaurante);
                    objReseña.Titulo_Reseña = resultado.tituloReseña;
                    objReseña.Contenido_Reseña = resultado.contenidoReseña;
                    objReseña.Fecha_RegistroReseña = Convert.ToDateTime(resultado.Fecha);
                    objReseña.Nom_Restaurante = resultado.nomRestaurante;

                    objListaReseñas.Add(objReseña);
                }

                return objListaReseñas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ReseñaBE> GetAllReseñasUsuario(Int16 idUsua)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<ReseñaBE> objListaReseñas = new List<ReseñaBE>();

            try
            {
                var query = MisReservas.usp_ListarMisReseñas(idUsua);

                foreach (var resultado in query)
                {
                    ReseñaBE objReseña = new ReseñaBE();

                    objReseña.Id_Reseña = Convert.ToInt16(resultado.idReseña);
                    objReseña.Id_Usuario = Convert.ToInt16(resultado.idUsuario);
                    objReseña.Id_Restaurante = Convert.ToInt16(resultado.idRestaurante);
                    objReseña.Titulo_Reseña = resultado.tituloReseña;
                    objReseña.Contenido_Reseña = resultado.contenidoReseña;
                    objReseña.Fecha_RegistroReseña = Convert.ToDateTime(resultado.Fecha);
                    objReseña.Nom_Restaurante = resultado.nomRestaurante;

                    objListaReseñas.Add(objReseña);
                }

                return objListaReseñas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ReseñaBE GetReseña(Int16 idRese)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();

            try
            {
                Reseña objReseña = (from miReseña in MisReservas.Reseña
                                    where miReseña.idReseña == idRese
                                    select miReseña).FirstOrDefault();

                ReseñaBE objReseñaBE = new ReseñaBE();
                objReseñaBE.Id_Reseña = Convert.ToInt16(objReseña.idReseña);
                objReseñaBE.Id_Usuario = Convert.ToInt16(objReseña.idUsuario);
                objReseñaBE.Id_Restaurante = Convert.ToInt16(objReseña.idRestaurante);
                objReseñaBE.Titulo_Reseña = objReseña.tituloReseña;
                objReseñaBE.Contenido_Reseña = objReseña.contenidoReseña;
                objReseñaBE.Fecha_RegistroReseña = objReseñaBE.Fecha_RegistroReseña;

                return objReseñaBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean UpdateReseña(ReseñaBE objReseñaBE, Int16 idRese)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();

            try
            {
                MisReservas.usp_ActualizarReseña(idRese, objReseñaBE.Titulo_Reseña, objReseñaBE.Contenido_Reseña);

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertReseña(ReseñaBE objReseñaBE, Int16 idUsua, Int16 idResta)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();

            try
            {
                MisReservas.usp_AñadirReseña(idUsua, idResta, objReseñaBE.Titulo_Reseña, objReseñaBE.Contenido_Reseña);

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean DeleteReseña(Int16 idRese)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();

            try
            {
                MisReservas.usp_EliminarReseña(idRese);

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
