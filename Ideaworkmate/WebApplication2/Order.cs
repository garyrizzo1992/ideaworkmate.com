//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrdersProducts = new HashSet<OrdersProduct>();
        }
    
        public System.Guid ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Totalprice { get; set; }
        public string Status { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}