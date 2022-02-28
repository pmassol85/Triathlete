using System;
using System.Collections.Generic;

#nullable disable

namespace Triathlete.Models
{
    public partial class LicenceClub
    {
        public int LicId { get; set; }
        public int? ClubIdEntrainer { get; set; }
        public int ClubIdAdherer { get; set; }
        public DateTime? LicDatePremiereLice { get; set; }

        public virtual Club ClubIdAdhererNavigation { get; set; }
        public virtual Club ClubIdEntrainerNavigation { get; set; }
        public virtual Licence Lic { get; set; }
    }
}
