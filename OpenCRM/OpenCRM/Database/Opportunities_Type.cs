//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenCRM.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Opportunities_Type
    {
        public Opportunities_Type()
        {
            this.Opportunities = new HashSet<Opportunities>();
        }
    
        public int OpportunityTypeId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Opportunities> Opportunities { get; set; }
    }
}
