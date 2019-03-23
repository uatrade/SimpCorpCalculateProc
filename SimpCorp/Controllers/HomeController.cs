using SimpCorp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpCorp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Caclulate(Invest invest)
        {
            try
            {
                InvestMetods investMetods = new InvestMetods();
                double periodInvestMonth = investMetods.CountMonth(invest);
                if (periodInvestMonth< 1)
                {
                    return View("Index");
                }
                int numOfmonth = (int)Math.Ceiling(periodInvestMonth);

                double procInMonth = invest.annualProcR / 12 / 100;  //% invest Month
                double K = procInMonth * Math.Pow((1 + procInMonth), periodInvestMonth) / (Math.Pow((1 + procInMonth), periodInvestMonth) - 1);

                ViewBag.NumOfMonth = numOfmonth;
                ViewBag.PaidOfMonth = invest.investAmountX * K;
                ViewBag.FinishRefundDate = invest.calculation_date;

                return View("Index", invest);
            }
            catch (Exception)
            {
                return View("Index");
            }
        }

    }
}