using System;
using System.Collections.Generic;
using System.Text;

namespace HCP.Config.DO
{
   public class DO_TaxIdentification
    {
        public int Isdcode { get; set; }
        public int TaxCode { get; set; }
        public string TaxDesc { get; set; }
        public int TaxIdentificationId { get; set; }
        public string TaxIdentificationDesc { get; set; }
        public string StateCode { get; set; }
        public bool ActiveStatus { get; set; }
        public string FormId { get; set; }
        public int UserID { get; set; }
        public string TerminalID { get; set; }
    }
}
