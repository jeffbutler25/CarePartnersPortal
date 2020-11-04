using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class ITEquipmentOrder
    {
        [Key]
        public int ID { get; set; }
        public DateTime OrderDateTime { get; set; }
        public string Requester { get; set; }
        public string RequestedFor { get; set; }
        public bool OtherAddress { get; set; }
        public string Address { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public List<Branch> Branches { get; set; }
        public List<Department> Departments { get; set; }
        public List<OrderItem> Cart { get; set; }
        public string AdditionalInformaiton { get; set; }
        public bool Approved { get; set; } = false;
        public DateTime ApprovalDateTime { get; set; }
        public string Approver { get; set; }

    }
}
