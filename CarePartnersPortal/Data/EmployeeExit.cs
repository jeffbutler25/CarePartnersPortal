using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class EmployeeExit
    {
        public List<string> ExitTypes { get; set; }
        [Required]
        public string ExitType { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public DateTime? ExitDate { get; set; }
        public string EmployeeNumber { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string HardwareReturned { get; set; }
        [Required]
        public string HardwareComments { get; set; }
        public string AdditionalDetails { get; set; }
        public string ForwardEmail { get; set; }
        public string ForwardEmailTo { get; set; }
        public string AccessToEmail { get; set; }
        public string AccessToEmailFor { get; set; }
        public string AccessToStoredFiles { get; set; }
        public string AccessToStoredFilesFor { get; set; }
        public string SetOutOfOffice { get; set; }
        public string SetOutOfOfficeTo { get; set; }

        public EmployeeExit()
        {
            ExitTypes = new List<string>()
            {
                "",
                "LOA",
                "Termination"
            };
        }
    }
}
