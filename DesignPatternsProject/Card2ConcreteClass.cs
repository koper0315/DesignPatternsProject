using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    class Card2ConcreteClass : AbPayClass
    {
        public override void CardAuthentication()
        {
            //card2 specko hitelesites
        }

        public override void PaymentFeedBack()
        {
            //card2 specko osszeg levonasa
        }

        public override void PayMethod()
        {
            //card2 specko visszaigazolas
        }
    }
}
