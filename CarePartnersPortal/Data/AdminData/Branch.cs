using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class Branch
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Approvers { get; set; }
    }
}
