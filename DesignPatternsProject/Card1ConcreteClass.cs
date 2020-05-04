using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    class Card1ConcreteClass : AbPayClass
    {
        public override void CardAuthentication()
        {
            //card1 specko hitelesites
        }

        public override void PaymentFeedBack()
        {
            //card1 specko osszeg levonasa
        }

        public override void PayMethod()
        {
            //card1 specko visszaigazolas
        }
    }
}
