using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace ServiciosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioRestaurantes" en el código y en el archivo de configuración a la vez.
    public class ServicioRestaurantes : IServicioRestaurantes
    {
        public List<RestauranteBE> GetAllRestaurantes()
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<RestauranteBE> objListaRestaurante = new List<RestauranteBE>();

            try
            {
                var query = MisReservas.usp_ListarRestaurante();

                foreach (var resultado in query)
                {
                    RestauranteBE objRestaurante = new RestauranteBE();

                    objRestaurante.Id_Restaurante = Convert.ToInt16(resultado.idRestaurante);
                    objRestaurante.Cate_Restaurante = Convert.ToInt16(resultado.idCategoria);
                    objRestaurante.Distri_Restaurante = Convert.ToInt16(resultado.idDistrito);
                    objRestaurante.Nom_Restaurante = resultado.nomRestaurante;
                    objRestaurante.Direc_Restaurante = resultado.direcRestaurante;
                    objRestaurante.Tele_Restaurante = resultado.teleRestaurante;
                    objRestaurante.FecRegistro_Restaurante = Convert.ToDateTime(resultado.fecRegistroRestaurante);
                    objRestaurante.UsuRegistro_Restaurante = resultado.usuRegistroRestaurante;
                    objRestaurante.FecUltModi_Restaurante = Convert.ToDateTime(resultado.fecUltModiRestaurante);
                    objRestaurante.UsuUltModi_Restaurante = resultado.usuUltModiRestaurante;
                    objRestaurante.Estado_Restaurante = Convert.ToInt16(resultado.estadoRestaurante);
                    objRestaurante.Nom_DistritoRestaurante = resultado.nomDistrito;
                    objRestaurante.Nom_CategoriaRestaurante = resultado.nomCategoria;
                    objRestaurante.Nom_EstadoRestaurante = resultado.Estado;

                    objListaRestaurante.Add(objRestaurante);
                }

                return objListaRestaurante;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RestauranteBE> GetAllRestaurantesActivo()
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<RestauranteBE> objListaRestaurante = new List<RestauranteBE>();

            try
            {
                var query = MisReservas.usp_ListarRestauranteActivos();

                foreach (var resultado in query)
                {
                    RestauranteBE objRestaurante = new RestauranteBE();

                    objRestaurante.Id_Restaurante = Convert.ToInt16(resultado.idRestaurante);
                    objRestaurante.Cate_Restaurante = Convert.ToInt16(resultado.idCategoria);
                    objRestaurante.Distri_Restaurante = Convert.ToInt16(resultado.idDistrito);
                    objRestaurante.Nom_Restaurante = resultado.nomRestaurante;
                    objRestaurante.Direc_Restaurante = resultado.direcRestaurante;
                    objRestaurante.Tele_Restaurante = resultado.teleRestaurante;
                    objRestaurante.Estado_Restaurante = Convert.ToInt16(resultado.estadoRestaurante);
                    objRestaurante.Nom_DistritoRestaurante = resultado.nomDistrito;
                    objRestaurante.Nom_CategoriaRestaurante = resultado.nomCategoria;
                    objRestaurante.Nom_EstadoRestaurante = resultado.Estado;

                    objListaRestaurante.Add(objRestaurante);
                }

                return objListaRestaurante;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public RestauranteBE GetRestaurante(Int16 idResta)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();

            try
            {
                vListadoRestaurantes objListadoRestaurantes = (from miRestaurante in MisReservas.vListadoRestaurantes
                                                               where miRestaurante.idRestaurante == idResta
                                                               select miRestaurante).FirstOrDefault();

                RestauranteBE objRestauranteBE = new RestauranteBE();
                objRestauranteBE.Id_Restaurante = Convert.ToInt16(objListadoRestaurantes.idRestaurante);
                objRestauranteBE.Cate_Restaurante = Convert.ToInt16(objListadoRestaurantes.idCategoria);
                objRestauranteBE.Distri_Restaurante = Convert.ToInt16(objListadoRestaurantes.idDistrito);
                objRestauranteBE.Nom_Restaurante = objListadoRestaurantes.nomRestaurante;
                objRestauranteBE.Direc_Restaurante = objListadoRestaurantes.direcRestaurante;
                objRestauranteBE.Tele_Restaurante = objListadoRestaurantes.teleRestaurante;
                objRestauranteBE.FecRegistro_Restaurante = Convert.ToDateTime(objListadoRestaurantes.fecRegistroRestaurante);
                objRestauranteBE.UsuRegistro_Restaurante = objListadoRestaurantes.usuRegistroRestaurante;
                objRestauranteBE.FecUltModi_Restaurante = Convert.ToDateTime(objListadoRestaurantes.fecUltModiRestaurante);
                objRestauranteBE.UsuUltModi_Restaurante = objListadoRestaurantes.usuUltModiRestaurante;
                objRestauranteBE.Estado_Restaurante = Convert.ToInt16(objListadoRestaurantes.estadoRestaurante);
                objRestauranteBE.Nom_DistritoRestaurante = objListadoRestaurantes.nomDistrito;
                objRestauranteBE.Nom_CategoriaRestaurante = objListadoRestaurantes.nomCategoria;
                objRestauranteBE.Nom_EstadoRestaurante = objListadoRestaurantes.Estado;

                return objRestauranteBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertRestaurante(RestauranteBE objRestauranteBE)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();

            try
            {
                MisReservas.usp_InsertarRestaurante(objRestauranteBE.Cate_Restaurante, objRestauranteBE.Distri_Restaurante, objRestauranteBE.Nom_Restaurante, objRestauranteBE.Direc_Restaurante, objRestauranteBE.Tele_Restaurante, objRestauranteBE.UsuRegistro_Restaurante, objRestauranteBE.Estado_Restaurante);

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean UpdateRestaurante(RestauranteBE objRestauranteBE)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();

            try
            {
                MisReservas.usp_ActualizarRestaurante(objRestauranteBE.Id_Restaurante, objRestauranteBE.Nom_Restaurante, objRestauranteBE.Direc_Restaurante, objRestauranteBE.Tele_Restaurante, objRestauranteBE.UsuUltModi_Restaurante, objRestauranteBE.Estado_Restaurante, objRestauranteBE.Cate_Restaurante, objRestauranteBE.Distri_Restaurante);

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RestauranteBE> GetAllRestaurantesPorDistrito(Int16 idDistri)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<RestauranteBE> objListaRestaurante = new List<RestauranteBE>();

            try
            {
                var query = MisReservas.usp_ListarRestaurantePorDistrito(idDistri);

                foreach (var resultado in query)
                {
                    RestauranteBE objRestaurante = new RestauranteBE();

                    objRestaurante.Id_Restaurante = Convert.ToInt16(resultado.idRestaurante);
                    objRestaurante.Cate_Restaurante = Convert.ToInt16(resultado.idCategoria);
                    objRestaurante.Distri_Restaurante = Convert.ToInt16(resultado.idDistrito);
                    objRestaurante.Nom_Restaurante = resultado.nomRestaurante;
                    objRestaurante.Direc_Restaurante = resultado.direcRestaurante;
                    objRestaurante.Tele_Restaurante = resultado.teleRestaurante;
                    objRestaurante.Estado_Restaurante = Convert.ToInt16(resultado.estadoRestaurante);
                    objRestaurante.Nom_DistritoRestaurante = resultado.nomDistrito;
                    objRestaurante.Nom_CategoriaRestaurante = resultado.nomCategoria;
                    objRestaurante.Nom_EstadoRestaurante = resultado.Estado;

                    objListaRestaurante.Add(objRestaurante);
                }

                return objListaRestaurante;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RestauranteBE> GetAllRestaurantesPorCategoria(Int16 idCate)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<RestauranteBE> objListaRestaurante = new List<RestauranteBE>();

            try
            {
                var query = MisReservas.usp_ListarRestaurantePorCategoria(idCate);

                foreach (var resultado in query)
                {
                    RestauranteBE objRestaurante = new RestauranteBE();

                    objRestaurante.Id_Restaurante = Convert.ToInt16(resultado.idRestaurante);
                    objRestaurante.Cate_Restaurante = Convert.ToInt16(resultado.idCategoria);
                    objRestaurante.Distri_Restaurante = Convert.ToInt16(resultado.idDistrito);
                    objRestaurante.Nom_Restaurante = resultado.nomRestaurante;
                    objRestaurante.Direc_Restaurante = resultado.direcRestaurante;
                    objRestaurante.Tele_Restaurante = resultado.teleRestaurante;
                    objRestaurante.Estado_Restaurante = Convert.ToInt16(resultado.estadoRestaurante);
                    objRestaurante.Nom_DistritoRestaurante = resultado.nomDistrito;
                    objRestaurante.Nom_CategoriaRestaurante = resultado.nomCategoria;
                    objRestaurante.Nom_EstadoRestaurante = resultado.Estado;

                    objListaRestaurante.Add(objRestaurante);
                }

                return objListaRestaurante;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RestauranteBE> GetAllRestaurantesPorCategoriaDistrito(Int16 idCate, Int16 idDistri)
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<RestauranteBE> objListaRestaurante = new List<RestauranteBE>();

            try
            {
                var query = MisReservas.usp_ListarRestaurantePorCategoriaDistrito(idCate, idDistri);

                foreach (var resultado in query)
                {
                    RestauranteBE objRestaurante = new RestauranteBE();

                    objRestaurante.Id_Restaurante = Convert.ToInt16(resultado.idRestaurante);
                    objRestaurante.Cate_Restaurante = Convert.ToInt16(resultado.idCategoria);
                    objRestaurante.Distri_Restaurante = Convert.ToInt16(resultado.idDistrito);
                    objRestaurante.Nom_Restaurante = resultado.nomRestaurante;
                    objRestaurante.Direc_Restaurante = resultado.direcRestaurante;
                    objRestaurante.Tele_Restaurante = resultado.teleRestaurante;
                    objRestaurante.Estado_Restaurante = Convert.ToInt16(resultado.estadoRestaurante);
                    objRestaurante.Nom_DistritoRestaurante = resultado.nomDistrito;
                    objRestaurante.Nom_CategoriaRestaurante = resultado.nomCategoria;
                    objRestaurante.Nom_EstadoRestaurante = resultado.Estado;

                    objListaRestaurante.Add(objRestaurante);
                }

                return objListaRestaurante;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RestauranteBE> GetAllDistritos()
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<RestauranteBE> objListaRestaurante = new List<RestauranteBE>();

            try
            {
                var query = MisReservas.usp_Distritos();

                foreach (var resultado in query)
                {
                    RestauranteBE objRestaurante = new RestauranteBE();

                    objRestaurante.Distri_Restaurante = Convert.ToInt16(resultado.idDistrito);
                    objRestaurante.Nom_DistritoRestaurante = resultado.nomDistrito;

                    objListaRestaurante.Add(objRestaurante);
                }

                return objListaRestaurante;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RestauranteBE> GetAllCategorias()
        {
            reservaRestauranteEntities MisReservas = new reservaRestauranteEntities();
            List<RestauranteBE> objListaRestaurante = new List<RestauranteBE>();

            try
            {
                var query = MisReservas.usp_Categorias();

                foreach (var resultado in query)
                {
                    RestauranteBE objRestaurante = new RestauranteBE();

                    objRestaurante.Cate_Restaurante = Convert.ToInt16(resultado.idCategoria);
                    objRestaurante.Nom_CategoriaRestaurante = resultado.nomCategoria;

                    objListaRestaurante.Add(objRestaurante);
                }

                return objListaRestaurante;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
