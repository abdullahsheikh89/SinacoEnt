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
    
    public partial class civ_EmpTypeDeptMap
    {
        public int Id { get; set; }
        public int DeptIDFK { get; set; }
        public int EmpTypeIDFK { get; set; }
    
        public virtual civ_Department civ_Department { get; set; }
        public virtual civ_EmployeeTypes civ_EmployeeTypes { get; set; }
    }
}
