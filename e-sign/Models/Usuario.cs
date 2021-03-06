//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace e_sign.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.DetalleOpciones = new HashSet<DetalleOpciones>();
            this.Documento = new HashSet<Documento>();
            this.DocumentosPermitidos = new HashSet<DocumentosPermitidos>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Empresa { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public Nullable<bool> Tipo { get; set; }
        public string Clave { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleOpciones> DetalleOpciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documento> Documento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosPermitidos> DocumentosPermitidos { get; set; }
        public virtual Empresa Empresa1 { get; set; }
    }
}
