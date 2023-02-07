﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosWCF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class reservaRestauranteEntities : DbContext
    {
        public reservaRestauranteEntities()
            : base("name=reservaRestauranteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Distrito> Distrito { get; set; }
        public virtual DbSet<Problema> Problema { get; set; }
        public virtual DbSet<Reclamo> Reclamo { get; set; }
        public virtual DbSet<Reseña> Reseña { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<Restaurantes> Restaurantes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<vListadoReservas> vListadoReservas { get; set; }
        public virtual DbSet<vListadoRestaurantes> vListadoRestaurantes { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int usp_ActualizarReseña(Nullable<int> idRese, string tituRese, string contRese)
        {
            var idReseParameter = idRese.HasValue ?
                new ObjectParameter("idRese", idRese) :
                new ObjectParameter("idRese", typeof(int));
    
            var tituReseParameter = tituRese != null ?
                new ObjectParameter("tituRese", tituRese) :
                new ObjectParameter("tituRese", typeof(string));
    
            var contReseParameter = contRese != null ?
                new ObjectParameter("contRese", contRese) :
                new ObjectParameter("contRese", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarReseña", idReseParameter, tituReseParameter, contReseParameter);
        }
    
        public virtual int usp_ActualizarReserva(Nullable<int> idUsua)
        {
            var idUsuaParameter = idUsua.HasValue ?
                new ObjectParameter("idUsua", idUsua) :
                new ObjectParameter("idUsua", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarReserva", idUsuaParameter);
        }
    
        public virtual int usp_ActualizarReservaRestaurante(Nullable<int> idResta)
        {
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarReservaRestaurante", idRestaParameter);
        }
    
        public virtual int usp_ActualizarRestaurante(Nullable<int> idResta, string nomResta, string direcResta, string teleResta, string usuUltModiResta, Nullable<int> estadoResta, Nullable<int> cateResta, Nullable<int> distriResta)
        {
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            var nomRestaParameter = nomResta != null ?
                new ObjectParameter("nomResta", nomResta) :
                new ObjectParameter("nomResta", typeof(string));
    
            var direcRestaParameter = direcResta != null ?
                new ObjectParameter("direcResta", direcResta) :
                new ObjectParameter("direcResta", typeof(string));
    
            var teleRestaParameter = teleResta != null ?
                new ObjectParameter("teleResta", teleResta) :
                new ObjectParameter("teleResta", typeof(string));
    
            var usuUltModiRestaParameter = usuUltModiResta != null ?
                new ObjectParameter("usuUltModiResta", usuUltModiResta) :
                new ObjectParameter("usuUltModiResta", typeof(string));
    
            var estadoRestaParameter = estadoResta.HasValue ?
                new ObjectParameter("estadoResta", estadoResta) :
                new ObjectParameter("estadoResta", typeof(int));
    
            var cateRestaParameter = cateResta.HasValue ?
                new ObjectParameter("cateResta", cateResta) :
                new ObjectParameter("cateResta", typeof(int));
    
            var distriRestaParameter = distriResta.HasValue ?
                new ObjectParameter("distriResta", distriResta) :
                new ObjectParameter("distriResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarRestaurante", idRestaParameter, nomRestaParameter, direcRestaParameter, teleRestaParameter, usuUltModiRestaParameter, estadoRestaParameter, cateRestaParameter, distriRestaParameter);
        }
    
        public virtual int usp_ActualizarUsuario(string correoUsu, string nomUsu, string apeUsu, string dniUsu, string teleUsu, Nullable<int> idUsu)
        {
            var correoUsuParameter = correoUsu != null ?
                new ObjectParameter("correoUsu", correoUsu) :
                new ObjectParameter("correoUsu", typeof(string));
    
            var nomUsuParameter = nomUsu != null ?
                new ObjectParameter("nomUsu", nomUsu) :
                new ObjectParameter("nomUsu", typeof(string));
    
            var apeUsuParameter = apeUsu != null ?
                new ObjectParameter("apeUsu", apeUsu) :
                new ObjectParameter("apeUsu", typeof(string));
    
            var dniUsuParameter = dniUsu != null ?
                new ObjectParameter("dniUsu", dniUsu) :
                new ObjectParameter("dniUsu", typeof(string));
    
            var teleUsuParameter = teleUsu != null ?
                new ObjectParameter("teleUsu", teleUsu) :
                new ObjectParameter("teleUsu", typeof(string));
    
            var idUsuParameter = idUsu.HasValue ?
                new ObjectParameter("idUsu", idUsu) :
                new ObjectParameter("idUsu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarUsuario", correoUsuParameter, nomUsuParameter, apeUsuParameter, dniUsuParameter, teleUsuParameter, idUsuParameter);
        }
    
        public virtual int usp_AñadirReseña(Nullable<int> idUsua, Nullable<int> idResta, string tituRese, string contRese)
        {
            var idUsuaParameter = idUsua.HasValue ?
                new ObjectParameter("idUsua", idUsua) :
                new ObjectParameter("idUsua", typeof(int));
    
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            var tituReseParameter = tituRese != null ?
                new ObjectParameter("tituRese", tituRese) :
                new ObjectParameter("tituRese", typeof(string));
    
            var contReseParameter = contRese != null ?
                new ObjectParameter("contRese", contRese) :
                new ObjectParameter("contRese", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AñadirReseña", idUsuaParameter, idRestaParameter, tituReseParameter, contReseParameter);
        }
    
        public virtual int usp_CancelarReserva(Nullable<int> idUsua, Nullable<int> idReser)
        {
            var idUsuaParameter = idUsua.HasValue ?
                new ObjectParameter("idUsua", idUsua) :
                new ObjectParameter("idUsua", typeof(int));
    
            var idReserParameter = idReser.HasValue ?
                new ObjectParameter("idReser", idReser) :
                new ObjectParameter("idReser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_CancelarReserva", idUsuaParameter, idReserParameter);
        }
    
        public virtual ObjectResult<usp_Categorias_Result> usp_Categorias()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Categorias_Result>("usp_Categorias");
        }
    
        public virtual ObjectResult<string> usp_ConsultarDistrito(Nullable<int> idDistri)
        {
            var idDistriParameter = idDistri.HasValue ?
                new ObjectParameter("idDistri", idDistri) :
                new ObjectParameter("idDistri", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_ConsultarDistrito", idDistriParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarReseña_Result> usp_ConsultarReseña(Nullable<int> idRese)
        {
            var idReseParameter = idRese.HasValue ?
                new ObjectParameter("idRese", idRese) :
                new ObjectParameter("idRese", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarReseña_Result>("usp_ConsultarReseña", idReseParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarRestaurante_Result> usp_ConsultarRestaurante(Nullable<int> idResta)
        {
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarRestaurante_Result>("usp_ConsultarRestaurante", idRestaParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarRestauranteWeb_Result> usp_ConsultarRestauranteWeb(Nullable<int> idResta)
        {
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarRestauranteWeb_Result>("usp_ConsultarRestauranteWeb", idRestaParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarUsuario_Result> usp_ConsultarUsuario(string correoUsu)
        {
            var correoUsuParameter = correoUsu != null ?
                new ObjectParameter("correoUsu", correoUsu) :
                new ObjectParameter("correoUsu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarUsuario_Result>("usp_ConsultarUsuario", correoUsuParameter);
        }
    
        public virtual ObjectResult<usp_Distritos_Result> usp_Distritos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Distritos_Result>("usp_Distritos");
        }
    
        public virtual int usp_EliminarReseña(Nullable<int> idRese)
        {
            var idReseParameter = idRese.HasValue ?
                new ObjectParameter("idRese", idRese) :
                new ObjectParameter("idRese", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_EliminarReseña", idReseParameter);
        }
    
        public virtual int usp_InsertarReserva(Nullable<int> idUsua, Nullable<int> idResta, Nullable<System.DateTime> fechaReser, Nullable<int> cantPerso)
        {
            var idUsuaParameter = idUsua.HasValue ?
                new ObjectParameter("idUsua", idUsua) :
                new ObjectParameter("idUsua", typeof(int));
    
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            var fechaReserParameter = fechaReser.HasValue ?
                new ObjectParameter("fechaReser", fechaReser) :
                new ObjectParameter("fechaReser", typeof(System.DateTime));
    
            var cantPersoParameter = cantPerso.HasValue ?
                new ObjectParameter("cantPerso", cantPerso) :
                new ObjectParameter("cantPerso", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarReserva", idUsuaParameter, idRestaParameter, fechaReserParameter, cantPersoParameter);
        }
    
        public virtual int usp_InsertarRestaurante(Nullable<int> cateResta, Nullable<int> distriResta, string nomResta, string direcResta, string teleResta, string usuRegisResta, Nullable<int> estadoResta)
        {
            var cateRestaParameter = cateResta.HasValue ?
                new ObjectParameter("cateResta", cateResta) :
                new ObjectParameter("cateResta", typeof(int));
    
            var distriRestaParameter = distriResta.HasValue ?
                new ObjectParameter("distriResta", distriResta) :
                new ObjectParameter("distriResta", typeof(int));
    
            var nomRestaParameter = nomResta != null ?
                new ObjectParameter("nomResta", nomResta) :
                new ObjectParameter("nomResta", typeof(string));
    
            var direcRestaParameter = direcResta != null ?
                new ObjectParameter("direcResta", direcResta) :
                new ObjectParameter("direcResta", typeof(string));
    
            var teleRestaParameter = teleResta != null ?
                new ObjectParameter("teleResta", teleResta) :
                new ObjectParameter("teleResta", typeof(string));
    
            var usuRegisRestaParameter = usuRegisResta != null ?
                new ObjectParameter("usuRegisResta", usuRegisResta) :
                new ObjectParameter("usuRegisResta", typeof(string));
    
            var estadoRestaParameter = estadoResta.HasValue ?
                new ObjectParameter("estadoResta", estadoResta) :
                new ObjectParameter("estadoResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarRestaurante", cateRestaParameter, distriRestaParameter, nomRestaParameter, direcRestaParameter, teleRestaParameter, usuRegisRestaParameter, estadoRestaParameter);
        }
    
        public virtual ObjectResult<usp_ListarMisReseñas_Result> usp_ListarMisReseñas(Nullable<int> idUsua)
        {
            var idUsuaParameter = idUsua.HasValue ?
                new ObjectParameter("idUsua", idUsua) :
                new ObjectParameter("idUsua", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarMisReseñas_Result>("usp_ListarMisReseñas", idUsuaParameter);
        }
    
        public virtual ObjectResult<usp_ListarReseñas_Result> usp_ListarReseñas(Nullable<int> idResta)
        {
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReseñas_Result>("usp_ListarReseñas", idRestaParameter);
        }
    
        public virtual ObjectResult<usp_ListarReservas_Result> usp_ListarReservas(Nullable<int> idUsua)
        {
            var idUsuaParameter = idUsua.HasValue ?
                new ObjectParameter("idUsua", idUsua) :
                new ObjectParameter("idUsua", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservas_Result>("usp_ListarReservas", idUsuaParameter);
        }
    
        public virtual ObjectResult<usp_ListarReservasRestaurante_Result> usp_ListarReservasRestaurante(Nullable<int> idResta)
        {
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasRestaurante_Result>("usp_ListarReservasRestaurante", idRestaParameter);
        }
    
        public virtual ObjectResult<usp_ListarReservasRestaurante_Paginacion_Result> usp_ListarReservasRestaurante_Paginacion(Nullable<int> idResta, Nullable<int> numPag)
        {
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            var numPagParameter = numPag.HasValue ?
                new ObjectParameter("NumPag", numPag) :
                new ObjectParameter("NumPag", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasRestaurante_Paginacion_Result>("usp_ListarReservasRestaurante_Paginacion", idRestaParameter, numPagParameter);
        }
    
        public virtual ObjectResult<usp_ListarRestaurante_Result> usp_ListarRestaurante()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarRestaurante_Result>("usp_ListarRestaurante");
        }
    
        public virtual ObjectResult<usp_ListarRestauranteActivos_Result> usp_ListarRestauranteActivos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarRestauranteActivos_Result>("usp_ListarRestauranteActivos");
        }
    
        public virtual int usp_NumPag_ListarReservasRestaurante_Paginacion(Nullable<int> idResta, ObjectParameter nUMREG)
        {
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_NumPag_ListarReservasRestaurante_Paginacion", idRestaParameter, nUMREG);
        }
    
        public virtual ObjectResult<usp_ListarRestaurantePorDistrito_Result> usp_ListarRestaurantePorDistrito(Nullable<int> idDistri)
        {
            var idDistriParameter = idDistri.HasValue ?
                new ObjectParameter("idDistri", idDistri) :
                new ObjectParameter("idDistri", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarRestaurantePorDistrito_Result>("usp_ListarRestaurantePorDistrito", idDistriParameter);
        }
    
        public virtual ObjectResult<usp_ListarRestaurantePorCategoria_Result> usp_ListarRestaurantePorCategoria(Nullable<int> idCate)
        {
            var idCateParameter = idCate.HasValue ?
                new ObjectParameter("idCate", idCate) :
                new ObjectParameter("idCate", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarRestaurantePorCategoria_Result>("usp_ListarRestaurantePorCategoria", idCateParameter);
        }
    
        public virtual ObjectResult<usp_ListarRestaurantePorCategoriaDistrito_Result> usp_ListarRestaurantePorCategoriaDistrito(Nullable<int> idCate, Nullable<int> idDistri)
        {
            var idCateParameter = idCate.HasValue ?
                new ObjectParameter("idCate", idCate) :
                new ObjectParameter("idCate", typeof(int));
    
            var idDistriParameter = idDistri.HasValue ?
                new ObjectParameter("idDistri", idDistri) :
                new ObjectParameter("idDistri", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarRestaurantePorCategoriaDistrito_Result>("usp_ListarRestaurantePorCategoriaDistrito", idCateParameter, idDistriParameter);
        }
    
        public virtual ObjectResult<usp_ListarReseñasTodas_Result> usp_ListarReseñasTodas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReseñasTodas_Result>("usp_ListarReseñasTodas");
        }
    
        public virtual ObjectResult<usp_ListarTodasReseñas_Result> usp_ListarTodasReseñas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarTodasReseñas_Result>("usp_ListarTodasReseñas");
        }
    
        public virtual ObjectResult<usp_ListarReservasPorDia_Result> usp_ListarReservasPorDia(Nullable<System.DateTime> fec)
        {
            var fecParameter = fec.HasValue ?
                new ObjectParameter("fec", fec) :
                new ObjectParameter("fec", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasPorDia_Result>("usp_ListarReservasPorDia", fecParameter);
        }
    
        public virtual ObjectResult<usp_ListarReservasPorDiaRestaurante_Result> usp_ListarReservasPorDiaRestaurante(Nullable<System.DateTime> fec, Nullable<int> idResta)
        {
            var fecParameter = fec.HasValue ?
                new ObjectParameter("fec", fec) :
                new ObjectParameter("fec", typeof(System.DateTime));
    
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasPorDiaRestaurante_Result>("usp_ListarReservasPorDiaRestaurante", fecParameter, idRestaParameter);
        }
    
        public virtual ObjectResult<usp_ListarReservasRestaurante1_Result> usp_ListarReservasRestaurante1(Nullable<int> idResta)
        {
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasRestaurante1_Result>("usp_ListarReservasRestaurante1", idRestaParameter);
        }
    
        public virtual ObjectResult<usp_ListarReservasRestaurantes_Result> usp_ListarReservasRestaurantes(Nullable<int> idResta)
        {
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReservasRestaurantes_Result>("usp_ListarReservasRestaurantes", idRestaParameter);
        }
    
        public virtual ObjectResult<usp_ListarReseña_Result> usp_ListarReseña(Nullable<int> idResta)
        {
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarReseña_Result>("usp_ListarReseña", idRestaParameter);
        }
    
        public virtual ObjectResult<usp_ListarTopUsuarioReservasPorRestaurante_Result> usp_ListarTopUsuarioReservasPorRestaurante(Nullable<int> idResta)
        {
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarTopUsuarioReservasPorRestaurante_Result>("usp_ListarTopUsuarioReservasPorRestaurante", idRestaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_NumPersonasDiaReservas(Nullable<System.DateTime> fec, Nullable<int> idResta)
        {
            var fecParameter = fec.HasValue ?
                new ObjectParameter("fec", fec) :
                new ObjectParameter("fec", typeof(System.DateTime));
    
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_NumPersonasDiaReservas", fecParameter, idRestaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_NumPersonasDiaReservasRestaurante(Nullable<System.DateTime> fec, Nullable<int> idResta)
        {
            var fecParameter = fec.HasValue ?
                new ObjectParameter("fec", fec) :
                new ObjectParameter("fec", typeof(System.DateTime));
    
            var idRestaParameter = idResta.HasValue ?
                new ObjectParameter("idResta", idResta) :
                new ObjectParameter("idResta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_NumPersonasDiaReservasRestaurante", fecParameter, idRestaParameter);
        }
    }
}
