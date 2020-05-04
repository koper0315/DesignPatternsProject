using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    abstract class AbPayClass
    {
        public void payPreparing()
        { 
        //vmi fizetest megelozo folyamat ezt mindig el kell vegezni
        }
        public bool succesful_payment = false;
        public abstract void CardAuthentication();
        public abstract void PayMethod();
        public abstract void PaymentFeedBack();
        public void TemplateMethod()
        {
            CardAuthentication();
            PayMethod();
            PaymentFeedBack();
        }
        public bool Feedback()
        {
            return succesful_payment;
        }
    }
}
