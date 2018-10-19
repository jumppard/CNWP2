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
    
    public partial class CARDPOOL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CARDPOOL()
        {
            this.CARD = new HashSet<CARD>();
            this.CARD_TRANSFER = new HashSet<CARD_TRANSFER>();
            this.CARDPOOLDETAIL = new HashSet<CARDPOOLDETAIL>();
        }
    
        public long CARDPOOL_ID { get; set; }
        public short ORGANIZATION_ID { get; set; }
        public short CARDPRODUCT_ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public int CARDOPTION { get; set; }
        public System.DateTime EXPIRYDATE { get; set; }
        public System.DateTime INSERTDATE { get; set; }
        public int INSERTUSER_ID { get; set; }
        public Nullable<System.DateTime> LASTUPDATEDATE { get; set; }
        public Nullable<int> LASTUPDATEUSER_ID { get; set; }
        public int STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARD> CARD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARD_TRANSFER> CARD_TRANSFER { get; set; }
        public virtual CARDPRODUCT CARDPRODUCT { get; set; }
        public virtual ORGANIZATION ORGANIZATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARDPOOLDETAIL> CARDPOOLDETAIL { get; set; }
    }
}
