using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class EmployeeHire
    {   
        [Required, Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Region { get; set; }
        [Required,Display(Name = "Hire Type")]
        public string HireType { get; set; }
        public string EmployeeNumber { get; set; }
        public string AdditonalRequirements { get; set; }        
    }
}
