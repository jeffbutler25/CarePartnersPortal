using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class EmployeeChange
    {
        [Required,Display(Name = "Change Type")]
        public string ChangeType { get; set; }
        [Required, Display(Name = "Name")]
        public string EmployeeName { get; set; }
        [Required, Display(Name = "Date Change Required")]
        public DateTime? DateChangeRequired { get; set; }
        public string Name { get; set; }
        public string NewName { get; set; }
        public string JobTitle { get; set; }
        public string Region { get; set; }
        public string AdditionalDetails { get; set; }
        public List<string> ChangeTypes { get; set; }

        public EmployeeChange()
        {
            ChangeTypes = new List<string>()
            {
                "",
                "Name Change",
                "Job Title",
            };
        }
    }
}
