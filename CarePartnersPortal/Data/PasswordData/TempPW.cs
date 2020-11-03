using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class TempPW
    {
        [Key]
        public int ID { get; set; }
        public int Code { get; set; }
        public string Access { get; set; }
        public string Password { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeExpiry { get; set; }
    }
}
