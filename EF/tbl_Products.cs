//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RelationalCRUD.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Products
    {
        public int ProductsID { get; set; }
        public string ProductsName { get; set; }
        public string ProductsPrice { get; set; }
        public Nullable<int> CatID { get; set; }
    
        public virtual tbl_Categories tbl_Categories { get; set; }
    }
}
