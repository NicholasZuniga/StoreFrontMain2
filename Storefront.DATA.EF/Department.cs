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
    
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            this.Empolyees = new HashSet<Empolyee>();
        }
    
        public int DepartmentID { get; set; }
        public string DepName { get; set; }
        public string DepCountry { get; set; }
        public string DepState { get; set; }
        public string DepCity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empolyee> Empolyees { get; set; }
    }
}
