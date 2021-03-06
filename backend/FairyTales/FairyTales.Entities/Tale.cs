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
    
    public partial class Tale
    {
        public Tale()
        {
            this.User_Tale = new HashSet<User_Tale>();
            this.Tale_Tag = new HashSet<Tale_Tag>();
        }
    
        public int Tale_ID { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public int Author_ID { get; set; }
        public string Text { get; set; }
        public string Audio { get; set; }
        public string Cover { get; set; }
        public int Category_ID { get; set; }
        public int Type_ID { get; set; }
        public int LikeCount { get; set; }
        public System.DateTime Date { get; set; }
        public string ShortDescription { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<User_Tale> User_Tale { get; set; }
        public virtual ICollection<Tale_Tag> Tale_Tag { get; set; }
        public virtual Type Type { get; set; }
    }
}
