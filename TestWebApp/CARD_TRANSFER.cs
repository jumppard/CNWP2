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
    
    public partial class CARD_TRANSFER
    {
        public int CARD_TRANSFER_ID { get; set; }
        public short ORGANIZATION_ID { get; set; }
        public short CARDPRODUCT_ID { get; set; }
        public int CARDOPTION { get; set; }
        public long CARDPOOL_ID { get; set; }
        public string OLD_CARDNO { get; set; }
        public string NEW_CARDNO { get; set; }
        public string DESCRIPTION { get; set; }
        public int BALANCE_TRANSFER { get; set; }
        public int BONUS_TRANSFER { get; set; }
        public int TRANSFER_TIMING { get; set; }
        public int TRANSFER_CASE { get; set; }
        public int TRANSFER_STATUS { get; set; }
        public Nullable<System.DateTime> TRANSFERDATE { get; set; }
        public Nullable<System.DateTime> SCHEDULEDATE { get; set; }
        public Nullable<System.DateTime> CANCELLEDDATE { get; set; }
        public System.DateTime INSERTDATE { get; set; }
        public int INSERTUSER_ID { get; set; }
        public Nullable<System.DateTime> LASTUPDATEDATE { get; set; }
        public Nullable<int> LASTUPDATEUSER_ID { get; set; }
    
        public virtual CONSTANT CONSTANT { get; set; }
        public virtual CONSTANT CONSTANT1 { get; set; }
        public virtual CARDPOOL CARDPOOL { get; set; }
        public virtual CARDPRODUCT CARDPRODUCT { get; set; }
        public virtual USER USER { get; set; }
        public virtual ORGANIZATION ORGANIZATION { get; set; }
        public virtual CONSTANT CONSTANT2 { get; set; }
        public virtual CONSTANT CONSTANT3 { get; set; }
        public virtual CONSTANT CONSTANT4 { get; set; }
    }
}
