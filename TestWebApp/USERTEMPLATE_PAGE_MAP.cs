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
    
    public partial class USERTEMPLATE_PAGE_MAP
    {
        public long USERTEMPLATE_PAGE_MAP_ID { get; set; }
        public short USER_TEMPLATE_ID { get; set; }
        public short PAGE_ID { get; set; }
        public int PERMISSION_TYPE_ID { get; set; }
    
        public virtual CONSTANT CONSTANT { get; set; }
        public virtual PAGE PAGE { get; set; }
        public virtual USERTEMPLATE USERTEMPLATE { get; set; }
    }
}