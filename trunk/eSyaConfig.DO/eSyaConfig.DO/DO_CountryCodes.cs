﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HCP.Config.DO
{
    public class DO_CountryCodes
    {
        public int Isdcode { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountryFlag { get; set; }
        public string CurrencyCode { get; set; }
        public string MobileNumberPattern { get; set; }
        //public string Uidlabel { get; set; }
        //public string Uidpattern { get; set; }
        public string Nationality { get; set; }
        public bool IsPoboxApplicable { get; set; }
        public string PoboxPattern { get; set; }
        public bool IsPinapplicable { get; set; }
        public string PincodePattern { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
        public string CurrencyName { get; set; }
        public List<DO_UIDPattern> _lstUIDpattern { get; set; }
    }
    public  class DO_UIDPattern
    {
        public int Isdcode { get; set; }
        public string Uidlabel { get; set; }
        public string Uidpattern { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
