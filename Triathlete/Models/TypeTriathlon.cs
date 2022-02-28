using System;
using System.Collections.Generic;

#nullable disable

namespace Triathlete.Models
{
    public partial class TypeTriathlon
    {
        public TypeTriathlon()
        {
            Triathlons = new HashSet<Triathlon>();
        }

        public int TypeId { get; set; }
        public string TypeLibelle { get; set; }
        public decimal? TypeDistanceVelo { get; set; }
        public decimal? TypeDistanceCourse { get; set; }
        public decimal? TypeDistanceNatation { get; set; }

        public virtual ICollection<Triathlon> Triathlons { get; set; }
    }
}
