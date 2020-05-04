using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    class LatteBuilder : CoffeeBuilder
    {
        public LatteBuilder()
        {
            coffee = new Coffee("Caffee Latte");
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
            coffee.SetSteamedMilk(2);
        }
        public override void AddFoamedMilk()
        {
            coffee.SetFoamedMilk(0);
        }
        public override void AddPrice()
        {
            coffee.SetPrice(900);
        }
    }
}
