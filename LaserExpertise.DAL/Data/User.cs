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
    
    public partial class User
    {
        public int id_user { get; set; }
        public Nullable<int> id_privilege { get; set; }
        public string Login_Name { get; set; }
        public string Password { get; set; }
    
        public virtual Privileges Privileges { get; set; }
    }
}
