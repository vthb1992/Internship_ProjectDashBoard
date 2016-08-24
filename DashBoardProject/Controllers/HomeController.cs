using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashBoardProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string currentDateSelected)
        {
            ViewBag.CurrentView = "Index";
            if (currentDateSelected == null)
            {
                if(Session["IndexCurrentDate"] != null)
                {
                    ViewBag.CurrentDate = Session["IndexCurrentDate"];
                }else
                {
                    ViewBag.CurrentDate = DateTime.Now.Date.ToString("MM/dd/yyyy");
                }
            }
            else
            {
                ViewBag.CurrentDate = currentDateSelected;
                Session["IndexCurrentDate"] = currentDateSelected;
            }
            
            ViewBag.testing = ViewBag.CurrentDate;

            return View();
        }
        
        public ActionResult Projects()
        {
            ViewBag.CurrentView = "Projects";
            

            return View();
        }

        public ActionResult ChangeRequests()
        {
            ViewBag.CurrentView = "ChangeRequests";
            return View();
        }

        public ActionResult CashCost()
        {
            ViewBag.CurrentView = "CashCost";
            return View();
        }

        public ActionResult CycleTime()
        {
            ViewBag.CurrentView = "CycleTime";
            return View();
        }

        public ActionResult Quality()
        {
            ViewBag.CurrentView = "Quality";
            return View();
        }

        public ActionResult TTMCYield()
        {
            ViewBag.CurrentView = "TTMCYield";
            return View();
        }

        public ActionResult PACManagers()
        {
            ViewBag.CurrentView = "PACManagers";
            return View();
        }

        public ActionResult OPMO()
        {
            ViewBag.CurrentView = "OPMO";
            return View();
        }

    }
}