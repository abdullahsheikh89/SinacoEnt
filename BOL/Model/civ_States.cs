//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class civ_States
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public civ_States()
        {
            this.civ_Cities = new HashSet<civ_Cities>();
        }
    
        public int Id { get; set; }
        public string State { get; set; }
        public int CountryIDFK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_Cities> civ_Cities { get; set; }
        public virtual civ_Countries civ_Countries { get; set; }
    }
}