//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMEDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMEDOR()
        {
            this.ORDEN_COMEDOR = new HashSet<ORDEN_COMEDOR>();
        }
    
        public decimal IDCOMEDOR { get; set; }
        public Nullable<decimal> PLATO_ID { get; set; }
        public Nullable<decimal> MINUTA_ID { get; set; }
        public Nullable<decimal> SERVICIO_ID { get; set; }
    
        public virtual MINUTA MINUTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDEN_COMEDOR> ORDEN_COMEDOR { get; set; }
        public virtual PLATO PLATO { get; set; }
        public virtual SERVICIO SERVICIO { get; set; }
    }
}