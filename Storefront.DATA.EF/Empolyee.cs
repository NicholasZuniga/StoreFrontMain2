//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Storefront.DATA.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empolyee
    {
        public int EmployeeID { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public string JobTitle { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public bool StillEmployed { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
