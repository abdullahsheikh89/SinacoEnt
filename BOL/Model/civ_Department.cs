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
    
    public partial class civ_Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public civ_Department()
        {
            this.civ_DepDesgnation = new HashSet<civ_DepDesgnation>();
            this.civ_Employees = new HashSet<civ_Employees>();
            this.civ_EmpTypeDeptMap = new HashSet<civ_EmpTypeDeptMap>();
        }
    
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int CompanyIDFK { get; set; }
        public bool IsActive { get; set; }
    
        public virtual civ_Company civ_Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_DepDesgnation> civ_DepDesgnation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_Employees> civ_Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_EmpTypeDeptMap> civ_EmpTypeDeptMap { get; set; }
    }
}
