using System;
using System.Collections.Generic;

namespace Smartstartups.Models
{
    public partial class Demographics
    {
        public decimal Id { get; set; }
        public string Asgs2015STCode { get; set; }
        public string STName { get; set; }
        public string LgaCode { get; set; }
        public string LgaName { get; set; }
        public string MalesNo { get; set; }
        public string FemaleNo { get; set; }
        public string PersonsNo { get; set; }
        public string SexRatioNo { get; set; }
        public string MedianAgeOfMales { get; set; }
        public string MedianAgeOfFemales { get; set; }
        public string MedianAgeOfPersons { get; set; }
        public string Age0to14Percentage { get; set; }
        public string Age15to64Percentage { get; set; }
        public string Age65andOver { get; set; }
    }
}
