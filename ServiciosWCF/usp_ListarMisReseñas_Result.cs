//------------------------------------------------------------------------------
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
    
    public partial class usp_ListarMisReseñas_Result
    {
        public int idReseña { get; set; }
        public int idUsuario { get; set; }
        public int idRestaurante { get; set; }
        public string tituloReseña { get; set; }
        public string contenidoReseña { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string nomRestaurante { get; set; }
    }
}
