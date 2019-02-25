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
    
    public partial class civ_Sites
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public civ_Sites()
        {
            this.civ_EmployeeTransfer = new HashSet<civ_EmployeeTransfer>();
            this.civ_Project = new HashSet<civ_Project>();
        }
    
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Lat { get; set; }
        public Nullable<decimal> Long { get; set; }
        public int AddressIDFK { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifedBy { get; set; }
        public System.DateTime ModifedDate { get; set; }
        public int CompanyIDFK { get; set; }
        public bool IsActive { get; set; }
        public int ClientIDFK { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual civ_Address civ_Address { get; set; }
        public virtual civ_Cities civ_Cities { get; set; }
        public virtual civ_Company civ_Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_EmployeeTransfer> civ_EmployeeTransfer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_Project> civ_Project { get; set; }
    }
}