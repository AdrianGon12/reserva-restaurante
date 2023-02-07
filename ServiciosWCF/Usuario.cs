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
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Reclamo = new HashSet<Reclamo>();
            this.Reseña = new HashSet<Reseña>();
            this.Reserva = new HashSet<Reserva>();
        }
    
        public int idUsuario { get; set; }
        public string correoUsuario { get; set; }
        public string contraUsuario { get; set; }
        public string dniUsuario { get; set; }
        public string nomUsuario { get; set; }
        public string apeUsuario { get; set; }
        public string teleUsuario { get; set; }
        public Nullable<System.DateTime> naciUsuario { get; set; }
        public int nivelUsuario { get; set; }
        public Nullable<System.DateTime> fecRegistroUsurio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reclamo> Reclamo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reseña> Reseña { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserva> Reserva { get; set; }
    }
}
