using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpCorp.Models
{
    public class InvestMetods
    {
        public double CountMonth(Invest invest) 
        {
            DateTime dt1 = new DateTime(invest.agreement_date.Year, invest.agreement_date.Month, invest.agreement_date.Day);
            DateTime dt2 = new DateTime(invest.calculation_date.Year, invest.calculation_date.Month, invest.calculation_date.Day);

            if (dt1 > dt2 || dt1 == dt2)
            {
                return 0;
            }

            double days = (dt2 - dt1).TotalDays;
            double mnt = 0;   // quantity of Month

            while (days != 0)
            {
                int inMnt = DateTime.DaysInMonth(dt1.Year, dt1.Month);
                if (days >= inMnt)
                {
                    days -= inMnt;
                    ++mnt;
                    dt1 = dt1.AddMonths(1);
                }
                else
                {
                    mnt += days / inMnt;
                    days = 0;
                }
            }
            return mnt;
        }
    }
}