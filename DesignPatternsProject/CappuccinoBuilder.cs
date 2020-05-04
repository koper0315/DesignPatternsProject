using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    class CappuccinoBuilder : CoffeeBuilder
    {
        public CappuccinoBuilder()
        {
            coffee = new Coffee("Cappuccino");
        }
        public override void AddCoffeeShot()
        {
            coffee.SetCoffeeShot(1);
        }
        public override void AddHotWater()
        {
            coffee.SetBoiledWater(0);
        }
        public override void AddSteamedMilk()
        {
            coffee.SetSteamedMilk(1);
        }

        public override void AddFoamedMilk()
        {
            coffee.SetFoamedMilk(1);
        }
        public override void AddPrice()
        {
            coffee.SetPrice(1000);
        }
    }
}
