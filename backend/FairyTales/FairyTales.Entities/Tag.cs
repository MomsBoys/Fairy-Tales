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
    
    public partial class Tag
    {
        public Tag()
        {
            this.Tale_Tag = new HashSet<Tale_Tag>();
        }
    
        public int Tag_ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Tale_Tag> Tale_Tag { get; set; }
    }
}