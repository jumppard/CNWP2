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
    
    public partial class USERTEMPLATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USERTEMPLATE()
        {
            this.USERTEMPLATE_PAGE_MAP = new HashSet<USERTEMPLATE_PAGE_MAP>();
        }
    
        public short USERTEMPLATE_ID { get; set; }
        public string USERTEMPLATENAME { get; set; }
        public short ORGANIZATION_ID { get; set; }
        public int USERTYPE_ID { get; set; }
        public System.DateTime INSERTDATE { get; set; }
        public Nullable<int> INSERTUSER_ID { get; set; }
        public Nullable<System.DateTime> LASTUPDATEDATE { get; set; }
        public Nullable<int> LASTUPDATEUSER_ID { get; set; }
        public int STATUS { get; set; }
    
        public virtual CONSTANT CONSTANT { get; set; }
        public virtual CONSTANT CONSTANT1 { get; set; }
        public virtual ORGANIZATION ORGANIZATION { get; set; }
        public virtual USER USER { get; set; }
        public virtual USER USER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERTEMPLATE_PAGE_MAP> USERTEMPLATE_PAGE_MAP { get; set; }
    }
}
