//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FairyTales.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Tale
    {
        public int User_Tale_ID { get; set; }
        public string User_ID { get; set; }
        public int Tale_ID { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsReaded { get; set; }
        public bool IsLiked { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Tale Tale { get; set; }
    }
}
