﻿using System;
using System.Collections.Generic;

namespace HCP.Config.DL.Entities
{
    public partial class GtEcmnfl
    {
        public GtEcmnfl()
        {
            GtEuusgr = new HashSet<GtEuusgr>();
        }

        public int FormId { get; set; }
        public int MainMenuId { get; set; }
        public int MenuItemId { get; set; }
        public int MenuKey { get; set; }
        public string FormNameClient { get; set; }
        public int FormIndex { get; set; }
        public bool ActiveStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedTerminal { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedTerminal { get; set; }

        public virtual GtEcfmfd Form { get; set; }
        public virtual GtEcmamn MainMenu { get; set; }
        public virtual ICollection<GtEuusgr> GtEuusgr { get; set; }
    }
}
