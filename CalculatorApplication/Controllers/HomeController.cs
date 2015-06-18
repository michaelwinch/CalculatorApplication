using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MonoRail.Framework;

namespace CalculatorApplication.Controllers
{
    [Layout("default"), Rescue("generalerror")]
    public class HomeController : SmartDispatcherController
    {
        public void Index()
        {
        }

        public void ErroneousAction()
        {
            throw new Exception("I'm a bad action.");
        }

        public void DataToTheView()
        {
            PropertyBag["name"] = "John Doe";
            PropertyBag["today"] = DateTime.Now;

            RenderView("data");
        }
    }
}