//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _01_Stanovnici_Hrvatske
{
    using System;
    using System.Collections.Generic;
    
    public partial class Adrese
    {
        public int ID { get; set; }
        public int IDMjesta { get; set; }
        public int IDStanovnika { get; set; }
        public string Adresa { get; set; }
        public Nullable<System.DateTime> AktivnaDo { get; set; }
    
        public virtual Mjesta Mjesta { get; set; }
        public virtual Stanovnici Stanovnici { get; set; }
    }
}
