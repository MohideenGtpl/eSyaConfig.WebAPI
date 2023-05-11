using System;
using System.Collections.Generic;

namespace HCP.Config.DL.Entities
{
    public partial class GtEcbsla
    {
        public int BusinessKey { get; set; }
        public int AreaCode { get; set; }
        public int CityCode { get; set; }
        public int StateCode { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string EMailId { get; set; }
        public string WebSite { get; set; }
        public string PhoneNumber { get; set; }
        public string EmergencyNumber { get; set; }
        public string FormId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }
    }
}
