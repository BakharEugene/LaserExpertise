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
    
    public partial class AUTHOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AUTHOR()
        {
            this.ARTWORK = new HashSet<ARTWORK>();
        }
    
        public int kod_author { get; set; }
        public string surname { get; set; }
        public string first_name { get; set; }
        public string another_name { get; set; }
        public string pseudonym { get; set; }
        public System.DateTime dateOfBirth { get; set; }
        public System.DateTime dateOfDeath { get; set; }
        public byte[] biography { get; set; }
        public string photo { get; set; }
        public string soc_status { get; set; }
        public string oridin { get; set; }
        public string education { get; set; }
        public string sex { get; set; }
        public string marital_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTWORK> ARTWORK { get; set; }
    }
}
