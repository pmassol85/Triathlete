using System;
using System.Collections.Generic;

#nullable disable

namespace Triathlete.Models
{
    public partial class Club
    {
        public Club()
        {
            LicenceClubClubIdAdhererNavigations = new HashSet<LicenceClub>();
            LicenceClubClubIdEntrainerNavigations = new HashSet<LicenceClub>();
        }

        public int ClubId { get; set; }
        public string ClubNom { get; set; }
        public string ClubRue { get; set; }
        public string ClubTel { get; set; }
        public string ClubVille { get; set; }
        public string ClubCp { get; set; }

        public virtual ICollection<LicenceClub> LicenceClubClubIdAdhererNavigations { get; set; }
        public virtual ICollection<LicenceClub> LicenceClubClubIdEntrainerNavigations { get; set; }
    }
}
