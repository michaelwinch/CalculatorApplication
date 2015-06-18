namespace CalculatorApplication.Controllers
{
    using System;
    using Castle.MonoRail.Framework;

    [Layout("default"), Rescue("generalerror")]
    public class ContactController : SmartDispatcherController
    {
        public void ContactForm()
        {
        }

        public void SendContactMessage([DataBind("contact")] Contact theContact)
        {
            // Pretend to save the contact ...

            // ..work work work..

            // Now lets add the contact to the property bag
            // so we can render a nice message back to the user

            PropertyBag["contact"] = theContact;

            RenderView("confirmation");
        }
    }
}