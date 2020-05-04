using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    class CaffeeAmericanoBuilder : CoffeeBuilder
    {
        public CaffeeAmericanoBuilder()
        {
            coffee = new Coffee("Caffee Americano");
        }
        public override void AddCoffeeShot()
        {
            coffee.SetCoffeeShot(1);
        }
        public override void AddHotWater()
        {
            coffee.SetBoiledWater(2);
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
            coffee.SetPrice(800);
        }
    }
}
