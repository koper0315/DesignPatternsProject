using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    class CoffeeMaker
    {
        public void Cook(CoffeeBuilder coffeeBuilder)
        {
            coffeeBuilder.AddCoffeeShot();
            coffeeBuilder.AddHotWater();
            coffeeBuilder.AddSteamedMilk();
            coffeeBuilder.AddFoamedMilk();
            coffeeBuilder.AddPrice();
        }
    }
}
