//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace H2ODBF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recibo
    {
        public int id_recibo { get; set; }
        public Nullable<int> id_pago { get; set; }
        public System.DateTime fecha_emision { get; set; }
        public decimal monto { get; set; }
        public string metodo_entrega { get; set; }
    
        public virtual Pago Pago { get; set; }
    }
}
