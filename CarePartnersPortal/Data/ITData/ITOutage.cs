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
        public string CrationDate { get; set; } = DateTime.Now.ToString();
        public string OutageStart { get; set; } = DateTime.Now.ToString();
        public string OutageEnd { get; set; }
        public string ImpactedSystems { get; set; }
        public string ImpactedUsers { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }

    }
}
