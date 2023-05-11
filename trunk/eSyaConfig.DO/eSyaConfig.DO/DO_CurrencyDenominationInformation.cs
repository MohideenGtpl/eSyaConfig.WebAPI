﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HCP.Config.DO
{
    public class DO_CurrencyDenominationInformation
    {
        
        public string CurrencyCode { get; set; }
        public string BnorCnId { get; set; }
        public decimal DenomId { get; set; }
        public string DenomDesc { get; set; }
        public decimal DenomConversion { get; set; }
        public int Sequence { get; set; }
        public DateTime EffectiveDate { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
