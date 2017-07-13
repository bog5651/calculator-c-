using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using calcularot.TwoArguments;

namespace Webinterface.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operations = new List<SelectListItem>
            {
                new SelectListItem {Text = "+", Value = "ButtonPluse"},
                new SelectListItem {Text = "-", Value = "ButtonMinus"},
                new SelectListItem {Text = "*", Value = "ButtonMulti"},
                new SelectListItem {Text = "/", Value = "ButtonDivision"}
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Calculate(double first, double second, string operation)
        {
            ITwoArgumentsCalculation calculator = TwoArgumentFactory.CreatCalculation(operation);
            var result = calculator.Calculate(first, second);
            return View(result);
        }
    }
}