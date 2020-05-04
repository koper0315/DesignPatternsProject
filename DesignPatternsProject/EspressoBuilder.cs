using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    class EspressoBuilder : CoffeeBuilder
    {
        public EspressoBuilder()
        {
            coffee = new Coffee("Espresso");
        }
        public override void AddCoffeeShot()
        {
            coffee.SetCoffeeShot(1);
        }
        public override void AddHotWater()
        {
            coffee.SetBoiledWater(1);
        }
        public override void AddSteamedMilk()
        {
            coffee.SetSteamedMilk(0);
        }
        public override void AddFoamedMilk()
        {
            coffee.SetFoamedMilk(0);
        }
        public override void AddPrice()
        {
            coffee.SetPrice(500);
        }
    }
}
