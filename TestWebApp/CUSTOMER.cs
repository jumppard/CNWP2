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
    
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            this.CAMPAIGNHISTORY = new HashSet<CAMPAIGNHISTORY>();
            this.CARD = new HashSet<CARD>();
            this.CUSTOMERPRIVATECHILDINFO = new HashSet<CUSTOMERPRIVATECHILDINFO>();
        }
    
        public long CUSTOMER_ID { get; set; }
        public short ORGANIZATION_ID { get; set; }
        public string CUSTOMERNO { get; set; }
        public string NAME { get; set; }
        public string MIDDLENAME { get; set; }
        public string SURNAME { get; set; }
        public Nullable<int> SEX { get; set; }
        public string SAPCODE { get; set; }
        public Nullable<int> SMSSTATUS { get; set; }
        public string PICTURE { get; set; }
        public byte[] IMAGE { get; set; }
        public string INTERNALID { get; set; }
        public Nullable<int> CUSTOMERTYPE_ID { get; set; }
        public Nullable<int> CORPORATECUSTOMER_ID { get; set; }
        public Nullable<int> CONTACTMETHOD { get; set; }
        public Nullable<int> CUSTOMERIMPORTANCE { get; set; }
        public Nullable<int> CARDDELIVERY { get; set; }
        public Nullable<int> CUSTOMERGROUP { get; set; }
        public Nullable<int> CUSTOMERSEGMENT { get; set; }
        public Nullable<int> MEMBERSHIPSESSION { get; set; }
        public Nullable<int> APPLIEDFORM { get; set; }
        public Nullable<int> CONTACTADDRESS { get; set; }
        public int ISANONYMOUS { get; set; }
        public System.DateTime INSERTDATE { get; set; }
        public int INSERTUSER_ID { get; set; }
        public Nullable<System.DateTime> LASTUPDATEDATE { get; set; }
        public Nullable<int> LASTUPDATEUSER_ID { get; set; }
        public int STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMPAIGNHISTORY> CAMPAIGNHISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARD> CARD { get; set; }
        public virtual CORPORATECUSTOMER CORPORATECUSTOMER { get; set; }
        public virtual ORGANIZATION ORGANIZATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMERPRIVATECHILDINFO> CUSTOMERPRIVATECHILDINFO { get; set; }
    }
}
