using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    class Coffee
    {
        private string _coffeeType;
        private int _boiledWater;
        private int _coffeeShot;
        private int _foamedMilk;
        private int _steamedMilk;
        private int _price;
        public Coffee(string coffeeType)
        {
            this._coffeeType = coffeeType;
        }
        public void SetBoiledWater(int boiledwater)
        {
            this._boiledWater = boiledwater;
        }
        public void SetCoffeeShot(int coffeeshot)
        {
            this._coffeeShot = coffeeshot;
        }
        public void SetFoamedMilk(int foamedmilk)
        {
            this._foamedMilk = foamedmilk;
        }
        public void SetSteamedMilk(int steamedmilk)
        {
            this._steamedMilk = steamedmilk;
        }
        public void SetPrice(int price)
        {
            this._price = price;
        }
        public int GetPrice()
        {
            return _price;
        }
        public string GetCoffeeType()
        {
            return _coffeeType;
        }
    }
}
