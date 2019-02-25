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
    
    public partial class civ_Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public civ_Employees()
        {
            this.civ_EmpAttendance = new HashSet<civ_EmpAttendance>();
            this.civ_Employees1 = new HashSet<civ_Employees>();
            this.civ_Employees11 = new HashSet<civ_Employees>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmpCode { get; set; }
        public string FatherName { get; set; }
        public int DeptIDFK { get; set; }
        public int DesIDFK { get; set; }
        public string Cnic { get; set; }
        public Nullable<decimal> DesiredSalary { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<decimal> HourRate { get; set; }
        public Nullable<int> ReportTo { get; set; }
        public System.DateTime JoiningDate { get; set; }
        public Nullable<System.DateTime> Dob { get; set; }
        public int ReligionIDFK { get; set; }
        public Nullable<int> PerAddIDFK { get; set; }
        public Nullable<int> TempAddIDFK { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
        public Nullable<int> Dependents { get; set; }
        public string EmergencyPersonName { get; set; }
        public string EmPhoneNo { get; set; }
        public string RelationShip { get; set; }
        public Nullable<int> RelationId { get; set; }
        public string EmpPic { get; set; }
        public string EmpCV { get; set; }
        public int CompanyIDFK { get; set; }
        public bool IsActive { get; set; }
        public bool IsMate { get; set; }
    
        public virtual civ_Address civ_Address { get; set; }
        public virtual civ_Address civ_Address1 { get; set; }
        public virtual civ_Company civ_Company { get; set; }
        public virtual civ_Department civ_Department { get; set; }
        public virtual civ_DepDesgnation civ_DepDesgnation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_EmpAttendance> civ_EmpAttendance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_Employees> civ_Employees1 { get; set; }
        public virtual civ_Employees civ_Employees2 { get; set; }
        public virtual civ_Religon civ_Religon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<civ_Employees> civ_Employees11 { get; set; }
        public virtual civ_Employees civ_Employees3 { get; set; }
    }
}
