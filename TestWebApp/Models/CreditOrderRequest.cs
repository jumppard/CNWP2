﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApp.Models
{
    public class CreditOrderRequest
    {
        public long ID { get; set; }
        public string PartnerName { get; set; }
        public long? RequestId { get; set; }
        public long? PartnerRequestId { get; set; }
        public long? ExternalCardId { get; set; }
        public decimal? TransactionAmount { get; set; }
        public string TransactionType { get; set; }
        public DateTime? CreationDateTime { get; set; }
        public DateTime? AnswerDateTime { get; set; }
        public string RequestStatus { get; set; }
        public int AccountTypeId { get; set; }
        public string AccountTypeIdName { get; set; }

    }
}