//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vjezba6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int Id { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string PayerDue { get; set; }
        public string ReciverDue { get; set; }
        public string Model { get; set; }
        public string PurpsoeCode { get; set; }
        public string Descrpiption { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual User User { get; set; }
    }
}
