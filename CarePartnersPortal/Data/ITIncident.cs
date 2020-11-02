using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class ITIncident
    {
        [Key]
        public string IncidentType { get; set; }
        public DateTime? OutageStart { get; set; }
        public DateTime? OutageEnd { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }

    }
}
