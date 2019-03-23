using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpCorp.Models
{
    public class Invest
    {
        int id { get; set; }
        public DateTime agreement_date { get; set; }
        public DateTime calculation_date { get; set; }
        public int investAmountX { get; set; }
        public double annualProcR { get; set; }
        public double periodYearN { get; set; }
        public double sumResult { get; set; }

    }
}