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
    
    public partial class INSTRUMENTAL_METHODS
    {
        public int kod_method { get; set; }
        public string method_name { get; set; }
        public string description { get; set; }
    
        public virtual PASSPORT_RESEARCH PASSPORT_RESEARCH { get; set; }
    }
}
