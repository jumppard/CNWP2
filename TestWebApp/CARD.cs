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
    
    public partial class CARD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CARD()
        {
            this.CAMPAIGNBLACKLIST = new HashSet<CAMPAIGNBLACKLIST>();
            this.CARD_EXTRA = new HashSet<CARD_EXTRA>();
        }
    
        public long CARD_ID { get; set; }
        public short ORGANIZATION_ID { get; set; }
        public int MERCHANT_ID { get; set; }
        public long CARDPOOL_ID { get; set; }
        public short CARDPRODUCT_ID { get; set; }
        public long CUSTOMER_ID { get; set; }
        public Nullable<int> CORPORATECUSTOMER_ID { get; set; }
        public Nullable<long> CARD_CRM_ID { get; set; }
        public Nullable<int> PACKAGE_ID { get; set; }
        public Nullable<int> ORDER_IN_PACKAGE { get; set; }
        public string CARDNO { get; set; }
        public string CARDNO_MASK { get; set; }
        public string CARDNO_HASH { get; set; }
        public byte[] CARDNO_ENCRYPTED { get; set; }
        public string FILENO { get; set; }
        public string NAMEONCARD { get; set; }
        public string COMPANY_NAME { get; set; }
        public string PVV { get; set; }
        public int PINTRYCOUNT { get; set; }
        public Nullable<System.DateTime> LAST_WRONG_PIN_TRY_DATE { get; set; }
        public string CARDSEQNO { get; set; }
        public System.DateTime EXPIRYDATE { get; set; }
        public string MIFARESERIALNO { get; set; }
        public Nullable<System.DateTime> CARDPRINTDATE { get; set; }
        public Nullable<System.DateTime> CARDDELIVERYDATE { get; set; }
        public int CARDLEVEL { get; set; }
        public Nullable<System.DateTime> ACTIVATIONDATE { get; set; }
        public string ACTIVATIONTERMINALID { get; set; }
        public int ACTIVATIONMETHOD { get; set; }
        public Nullable<bool> TRANSFER { get; set; }
        public Nullable<decimal> TRANSACTION_LIMIT { get; set; }
        public Nullable<decimal> DAILY_LIMIT { get; set; }
        public Nullable<decimal> NEXT_DAILY_LIMIT { get; set; }
        public System.DateTime INSERTDATE { get; set; }
        public int INSERTUSER_ID { get; set; }
        public Nullable<System.DateTime> LASTUPDATEDATE { get; set; }
        public Nullable<int> LASTUPDATEUSER_ID { get; set; }
        public int STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMPAIGNBLACKLIST> CAMPAIGNBLACKLIST { get; set; }
        public virtual CARDPOOL CARDPOOL { get; set; }
        public virtual CARDPRODUCT CARDPRODUCT { get; set; }
        public virtual CORPORATECUSTOMER CORPORATECUSTOMER { get; set; }
        public virtual CUSTOMER CUSTOMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARD_EXTRA> CARD_EXTRA { get; set; }
        public virtual ORGANIZATION ORGANIZATION { get; set; }
        public virtual FINANCIALINFO FINANCIALINFO { get; set; }
    }
}
