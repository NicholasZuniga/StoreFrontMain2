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
    
    public partial class Creator
    {
        public int CreatorID { get; set; }
        public int VidGameID { get; set; }
        public int CreatorInfoID { get; set; }
        public Nullable<int> CreatorOrder { get; set; }
    
        public virtual CreatorInfo CreatorInfo { get; set; }
        public virtual VideoGame VideoGame { get; set; }
    }
}