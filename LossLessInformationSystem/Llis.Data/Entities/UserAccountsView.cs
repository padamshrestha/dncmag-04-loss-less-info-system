//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Llis.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAccountsView
    {
        public int Id { get; set; }
        public int CreatedById { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int OperationsId { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Action { get; set; }
        public int UpdatedById { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    }
}
