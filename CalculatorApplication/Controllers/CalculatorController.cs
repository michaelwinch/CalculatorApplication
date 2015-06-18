using System.Web;
using Castle.MonoRail.Framework;

namespace CalculatorApplication.Controllers
{
    [Layout("default"), Rescue("generalerror")]
    public class CalculatorController : SmartDispatcherController
    {
        public void CalcForm()
        {
        }

        public void SendCalcMessage([DataBind("calculator")] Calculator theCalculator)
        {
            switch (theCalculator.Op)
            {
                case "add":
                    theCalculator.Ans = theCalculator.Num1 + theCalculator.Num2;
                    break;
                case "subtract":
                    theCalculator.Ans = theCalculator.Num1 - theCalculator.Num2;
                    break;
                case "multiply":
                    theCalculator.Ans = theCalculator.Num1 * theCalculator.Num2;
                    break;
                case "divide":
                    theCalculator.Ans = theCalculator.Num1 / theCalculator.Num2;
                    break;
            }
            
            PropertyBag["calculator"] = theCalculator;
            RenderView("calcform");
        }
    }
}