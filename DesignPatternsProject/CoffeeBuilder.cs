using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    abstract class CoffeeBuilder
    {
        protected Coffee coffee;
        public Coffee Coffee
        {
            get { return coffee; }
        }
        public abstract void AddCoffeeShot();
        public abstract void AddHotWater();
        public abstract void AddFoamedMilk();
        public abstract void AddSteamedMilk();
        public abstract void AddPrice();
    }
}
