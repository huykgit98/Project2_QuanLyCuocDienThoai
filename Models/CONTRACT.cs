//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTRACT
    {
        public string id { get; set; }
        public string id_sim { get; set; }
        public Nullable<System.DateTime> date_register { get; set; }
        public Nullable<int> fee { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual SIM SIM { get; set; }
    }
}
