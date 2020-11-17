using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class Region
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Approvers { get; set; }
        public string FrontlineStaffDL { get; set; }
        public string OfficeStaffDL { get; set; }
    }
}
