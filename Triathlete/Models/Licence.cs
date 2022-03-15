using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Triathlete.Models
{
    public partial class Licence
    {
        public Licence()
        {
            Inscriptions = new HashSet<Inscription>();
        }

        public int LicId { get; set; }
        public int CatId { get; set; }
        public byte[] LicPhoto { get; set; }
        public string LicNom { get; set; }
        public string LicPrenom { get; set; }
        public string LicSexe { get; set; }
        public string LicEmail { get; set; }
        public string LicRue { get; set; }
        public string LicCodePostal { get; set; }
        public string LicVille { get; set; }
        public DateTime LicDateNaissance { get; set; }

        public virtual Categorie Cat { get; set; }
        //public virtual LicenceClub LicenceClub { get; set; }
        public virtual ICollection<Inscription> Inscriptions { get; set; }

        [NotMapped]
        public string FullName { get { return this.LicNom + " " + this.LicPrenom; } }
    }
}
