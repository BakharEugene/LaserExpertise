//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaserExpertise.DAL.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DATE_REMARKS
    {
        public int kod_date { get; set; }
        public Nullable<int> kod_artwork { get; set; }
        public string remark_creation_date { get; set; }
    
        public virtual ARTWORK ARTWORK { get; set; }
        public virtual CREATION_DATE CREATION_DATE { get; set; }
    }
}
