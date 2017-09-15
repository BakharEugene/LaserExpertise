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
    
    public partial class POSITION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POSITION()
        {
            this.ARTWORK = new HashSet<ARTWORK>();
        }
    
        public int kod_object { get; set; }
        public Nullable<int> kod_country { get; set; }
        public Nullable<int> CIT_kod_location { get; set; }
        public Nullable<int> kod_city { get; set; }
        public Nullable<int> kod_location { get; set; }
        public string name_object { get; set; }
        public string type_object { get; set; }
        public string longitude_loc { get; set; }
        public string latitude_loc { get; set; }
        public string pos_address { get; set; }
        public byte[] description { get; set; }
    
        public virtual CITY CITY { get; set; }
        public virtual LOCATION LOCATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTWORK> ARTWORK { get; set; }
    }
}
