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
    
    public partial class PAINTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PAINTS()
        {
            this.PIGMENTS = new HashSet<PIGMENTS>();
        }
    
        public int kod_paint { get; set; }
        public string paint_name { get; set; }
        public string remark { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PIGMENTS> PIGMENTS { get; set; }
    }
}