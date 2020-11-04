using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class ITOutage
    {
        [Key]
        public string IncidentType { get; set; }
        public DateTime? CrationDate { get; set; }
        public DateTime? OutageStart { get; set; }
        public DateTime? OutageEnd { get; set; }
        public string ImpactedSystems { get; set; }
        public string ImpactedUsers { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }

    }
}
