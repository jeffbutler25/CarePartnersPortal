using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class GlobalForm
    {
        public string LabelStyle { get; set; }
        public string InputStyle { get; set; }
        public string LabelClass { get; set; }
        public string InputClass { get; set; }
        public string FormStyle { get; set; }
        public string FormClass { get; set; }
        public string Padding { get; set; }
        public List<string> Branchs { get; set; }
        public List<string> JobTitles { get; set; }
        public List<string> Departments { get; set; }
        public List<string> YesNo { get; set; }

        public GlobalForm()
        {
            InputStyle = "";// "align-content:center";
            InputClass = "col-md-2";
            LabelStyle = "text-align:right";
            LabelClass = "col-md-2";
            FormStyle = "";
            FormClass = "col-md-7";

            Branchs = new List<string>()
            {
                "",
                "WW",
                "CE",
                "NSM",
                "HNHB",
                "MH",                
            };

            JobTitles = new List<string>()
            {
                "",
                "PSW",
                "Nurse",
            };

            Departments = new List<string>()
            {
                "",
                "Payroll",
                "Billing",
                "Operations"
            };

            YesNo = new List<string>()
            {
                "",
                "Yes",
                "No"
            };
        }
    }


}
