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
    
    public partial class civ_Cities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public civ_Cities()
        {
            this.civ_Address = new HashSet<civ_Address>();
            this.civ_Sites = new HashSet<civ_Sites>();
        }
    
        public int Id { get; set; }
        public string CityName { get; set; }
        public int StateIDFK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_Address> civ_Address { get; set; }
        public virtual civ_States civ_States { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_Sites> civ_Sites { get; set; }
    }
}
