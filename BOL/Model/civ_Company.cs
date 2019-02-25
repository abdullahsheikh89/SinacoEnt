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
    
    public partial class civ_Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public civ_Company()
        {
            this.AspNetUsers = new HashSet<AspNetUser>();
            this.civ_Department = new HashSet<civ_Department>();
            this.civ_EmpAttendance = new HashSet<civ_EmpAttendance>();
            this.civ_Employees = new HashSet<civ_Employees>();
            this.civ_EmployeeTransfer = new HashSet<civ_EmployeeTransfer>();
            this.civ_EmployeeTypes = new HashSet<civ_EmployeeTypes>();
            this.civ_Project = new HashSet<civ_Project>();
            this.civ_Sites = new HashSet<civ_Sites>();
        }
    
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobileNo { get; set; }
        public string Fax { get; set; }
        public Nullable<int> DefaultPageSize { get; set; }
        public string CompanyImage { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Country { get; set; }
        public string ContactPersonFirstName { get; set; }
        public string ContactPersonLastName { get; set; }
        public string WebURL { get; set; }
        public string NTN { get; set; }
        public int CompanyTypeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
        public virtual civ_CompanyType civ_CompanyType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_Department> civ_Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_EmpAttendance> civ_EmpAttendance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_Employees> civ_Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_EmployeeTransfer> civ_EmployeeTransfer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_EmployeeTypes> civ_EmployeeTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_Project> civ_Project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_Sites> civ_Sites { get; set; }
    }
}