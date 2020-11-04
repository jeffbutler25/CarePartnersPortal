using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class ITSystem
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactsInternal { get; set; }
        public string ContactsExternal { get; set; }
        public string NotificationGroup { get; set; }
        public bool Impacted { get; set; } = false;
    }
}
