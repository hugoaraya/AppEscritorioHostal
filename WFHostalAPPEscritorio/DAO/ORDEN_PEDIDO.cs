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
    
    public partial class ORDEN_PEDIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDEN_PEDIDO()
        {
            this.RECEPCION_PRODUCTO = new HashSet<RECEPCION_PRODUCTO>();
        }
    
        public decimal IDORDEN_PEDIDO { get; set; }
        public decimal NRO_ORDEN { get; set; }
        public Nullable<decimal> EMPLEADO_ID { get; set; }
        public System.DateTime FECHA { get; set; }
        public Nullable<decimal> PROVEEDOR_ID { get; set; }
        public Nullable<decimal> ESTADO_ORDEN_PEDIDO_ID { get; set; }
        public string COMENTARIOS { get; set; }
    
        public virtual EMPLEADO EMPLEADO { get; set; }
        public virtual ESTADO_ORDEN_PEDIDO ESTADO_ORDEN_PEDIDO { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECEPCION_PRODUCTO> RECEPCION_PRODUCTO { get; set; }
    }
}
