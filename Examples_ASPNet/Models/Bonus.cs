//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examples_ASPNet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bonus
    {
        public int BonusID { get; set; }
        public int EmployeeID { get; set; }
        public decimal Value { get; set; }
    
        public virtual Employee Employees { get; set; }
    }
}
