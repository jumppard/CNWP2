//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class C___CONSTANT_PARTNER
    {
        public int id { get; set; }
        public int partner_id { get; set; }
        public string constant_name { get; set; }
        public string constant_value { get; set; }
        public System.DateTime insert_date { get; set; }
        public System.DateTime last_update_date { get; set; }
        public string constant_description { get; set; }
        public string material_id { get; set; }
    
        public virtual C___PARTNER C___PARTNER { get; set; }
    }
}
