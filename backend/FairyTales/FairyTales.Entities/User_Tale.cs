
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
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
