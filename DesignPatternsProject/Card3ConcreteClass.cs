using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    class Card3ConcreteClass : AbPayClass
    {
        public override void CardAuthentication()
        {
            //card3 specko hitelesites
        }

        public override void PaymentFeedBack()
        {
            //card3 specko osszeg levonasa
        }

        public override void PayMethod()
        {
            //card3 specko visszaigazolas
        }
    }
}
