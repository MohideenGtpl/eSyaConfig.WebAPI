﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HCP.Config.DO
{
    public class DO_BusinessSegment
    {
        public int BusinessId { get; set; }
        public int SegmentId { get; set; }
        public string SegmentDesc { get; set; }
        public bool IsMultiLocationApplicable { get; set; }
        public int Isdcode { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string OrgnDateFormat { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserID { get; set; }
        public string FormID { get; set; }
        public string TerminalID { get; set; }
    }    
}
