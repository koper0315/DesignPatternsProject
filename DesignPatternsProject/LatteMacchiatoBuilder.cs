using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    class LatteMacchiatoBuilder : CoffeeBuilder
    {
        public LatteMacchiatoBuilder()
        {
            coffee = new Coffee("Latte Macchiato");
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
            coffee.SetFoamedMilk(1);
        }
        public override void AddPrice()
        {
            coffee.SetPrice(1200);
        }
    }
}
