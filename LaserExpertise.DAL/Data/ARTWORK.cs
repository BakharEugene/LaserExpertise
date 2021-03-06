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
    
    public partial class ARTWORK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTWORK()
        {
            this.DATE_REMARKS = new HashSet<DATE_REMARKS>();
            this.FOCUS_SECTION_SpectralResearch_ = new HashSet<FOCUS_SECTION_SpectralResearch_>();
            this.FOTO = new HashSet<FOTO>();
            this.PASSPORT_RESEARCH = new HashSet<PASSPORT_RESEARCH>();
            this.POSITION = new HashSet<POSITION>();
        }
    
        public int kod_artwork { get; set; }
        public Nullable<int> kod_ptechnique { get; set; }
        public Nullable<int> kod_genre { get; set; }
        public Nullable<int> kod_perioda { get; set; }
        public Nullable<int> kod_location { get; set; }
        public Nullable<int> kod_school { get; set; }
        public Nullable<int> kod_pstyle { get; set; }
        public Nullable<int> kod_author { get; set; }
        public Nullable<int> Kod_ATPosition { get; set; }
        public string artwork_name { get; set; }
        public string original_name { get; set; }
        public string sizes { get; set; }
        public Nullable<System.DateTime> creation_date { get; set; }
        public string description { get; set; }
        public string basis { get; set; }
        public Nullable<decimal> Cost { get; set; }
    
        public virtual ARTWORK_GENRE ARTWORK_GENRE { get; set; }
        public virtual PAINTING_TECHNIQUE PAINTING_TECHNIQUE { get; set; }
        public virtual PAINTING_STYLE PAINTING_STYLE { get; set; }
        public virtual ARTWORK_TYPE_POSITION ARTWORK_TYPE_POSITION { get; set; }
        public virtual AUTHOR AUTHOR { get; set; }
        public virtual HISTORICAL_PERIOD HISTORICAL_PERIOD { get; set; }
        public virtual LOCATION LOCATION { get; set; }
        public virtual PAINTING_SCHOOL PAINTING_SCHOOL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATE_REMARKS> DATE_REMARKS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FOCUS_SECTION_SpectralResearch_> FOCUS_SECTION_SpectralResearch_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FOTO> FOTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PASSPORT_RESEARCH> PASSPORT_RESEARCH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POSITION> POSITION { get; set; }
    }
}
