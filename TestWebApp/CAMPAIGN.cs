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
    
    public partial class CAMPAIGN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAMPAIGN()
        {
            this.CAMPAIGNBLACKLIST = new HashSet<CAMPAIGNBLACKLIST>();
            this.CAMPAIGNCUSTOMER = new HashSet<CAMPAIGNCUSTOMER>();
            this.CAMPAIGNHISTORY = new HashSet<CAMPAIGNHISTORY>();
            this.CAMPAIGNLIMIT = new HashSet<CAMPAIGNLIMIT>();
            this.CAMPAIGNMESSAGE = new HashSet<CAMPAIGNMESSAGE>();
            this.CAMPAIGNPOINT = new HashSet<CAMPAIGNPOINT>();
            this.CAMPAIGNRFM = new HashSet<CAMPAIGNRFM>();
        }
    
        public int CAMPAIGN_ID { get; set; }
        public short ORGANIZATION_ID { get; set; }
        public string NAME { get; set; }
        public Nullable<int> CAMPAIGNTYPE { get; set; }
        public string SAPCODE { get; set; }
        public Nullable<short> COSTRATE { get; set; }
        public Nullable<int> WINTIME { get; set; }
        public Nullable<int> CAMPAIGNORDER { get; set; }
        public int ONLYTHIS { get; set; }
        public Nullable<int> WINBASEPOINT { get; set; }
        public System.DateTime STARTDATE { get; set; }
        public System.DateTime ENDDATE { get; set; }
        public Nullable<int> APPLYTYPE { get; set; }
        public bool VALIDTIMES { get; set; }
        public Nullable<int> CAMPAIGNPRIORITYLEVEL { get; set; }
        public Nullable<int> STANDARDREWARDSALLOWED { get; set; }
        public int RESETREWARDSAFTERCAMPAIGN { get; set; }
        public Nullable<int> RESETRELATEDCAMPAIGNS { get; set; }
        public Nullable<int> REWARDDELAYOPTION { get; set; }
        public Nullable<int> REWARDDELAYDAYS { get; set; }
        public int CUSTOMERCANPAYWITHPOINTS { get; set; }
        public Nullable<int> LASTDATETORECEIVEREWARD { get; set; }
        public Nullable<int> ZEROOUTBALANCEAFTERWIN { get; set; }
        public Nullable<int> ORDERGIFTSFROMPOS { get; set; }
        public string POSMENUNAME { get; set; }
        public Nullable<int> SHOWRESETORDECREASEDPOINTS { get; set; }
        public Nullable<int> SHOWEARNEDGIFTSONPOS { get; set; }
        public Nullable<int> WRITENUMBEROFGIFTSLEFT { get; set; }
        public Nullable<int> WRITEBALANCETORECEIVENEWGIFT { get; set; }
        public Nullable<long> NUMBEROFGIFTSBYAWARDED { get; set; }
        public Nullable<int> GIFTEARNINGRIGHTSINTIMEPERIOD { get; set; }
        public Nullable<int> MAXNUMBEROFTRXALLOWED { get; set; }
        public Nullable<int> MAXNUMBEROFGIFTSALLOWEDPERTRX { get; set; }
        public Nullable<int> MAXNUMBEROFGIFTSALLOWEDPERDAY { get; set; }
        public string SAPCODEUSEDININVOICE { get; set; }
        public Nullable<decimal> COSTPERCENTAGEFMERCHANT { get; set; }
        public Nullable<decimal> COSTREDUCTIONAMOUNTFOEACHGIFT { get; set; }
        public Nullable<int> DECREASECUSTOMERCONTRIBUTIONFROMCOST { get; set; }
        public Nullable<int> CALCULATECOSTFORMERCHANTSONZEROPOINTS { get; set; }
        public Nullable<int> CALCULATIONFREQUENCY { get; set; }
        public Nullable<int> SHOWGIFTNOTAWARDEDONPOS { get; set; }
        public string SCHEDULERCOLOR { get; set; }
        public Nullable<long> CARDPOOL_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<System.DateTime> POINTUSESTARTDATE { get; set; }
        public Nullable<System.DateTime> POINTUSEENDDATE { get; set; }
        public Nullable<decimal> TARGET_AMOUNT { get; set; }
        public Nullable<int> TARGET_COUNT { get; set; }
        public Nullable<short> BONUS_EFFECTIVE_DAY { get; set; }
        public System.DateTime INSERTDATE { get; set; }
        public int INSERTUSER_ID { get; set; }
        public Nullable<System.DateTime> LASTUPDATEDATE { get; set; }
        public Nullable<int> LASTUPDATEUSER_ID { get; set; }
        public int STATUS { get; set; }
    
        public virtual CONSTANT CONSTANT { get; set; }
        public virtual CONSTANT CONSTANT1 { get; set; }
        public virtual CONSTANT CONSTANT2 { get; set; }
        public virtual USER USER { get; set; }
        public virtual ORGANIZATION ORGANIZATION { get; set; }
        public virtual CONSTANT CONSTANT3 { get; set; }
        public virtual CONSTANT CONSTANT4 { get; set; }
        public virtual USER USER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMPAIGNBLACKLIST> CAMPAIGNBLACKLIST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMPAIGNCUSTOMER> CAMPAIGNCUSTOMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMPAIGNHISTORY> CAMPAIGNHISTORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMPAIGNLIMIT> CAMPAIGNLIMIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMPAIGNMESSAGE> CAMPAIGNMESSAGE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMPAIGNPOINT> CAMPAIGNPOINT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAMPAIGNRFM> CAMPAIGNRFM { get; set; }
    }
}
