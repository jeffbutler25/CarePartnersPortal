using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class ADUser
    {
        public string DistinguishedName { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DistplayName { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
    }
}
