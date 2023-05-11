using System;
using System.Collections.Generic;

namespace HCP.Config.DL.Entities
{
    public partial class GtEchlms
    {
        public int BusinessKey { get; set; }
        public DateTime HolidayDate { get; set; }
        public string HolidayDesc { get; set; }
        public bool ActiveStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }
    }
}
