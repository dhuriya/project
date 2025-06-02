using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Encapsulation
{
    public class CoffeeMachine
    {
        private int waterAmount;
        private int beansAmount;
        private bool isHeated;

        public CoffeeMachine(int water, int beans)
        {
            waterAmount = water;
            beansAmount = beans;
            isHeated = false;
        }
        private void HeatWater()
        {
            if (!isHeated)
            {
                Console.WriteLine("Heating water");
                isHeated = true;
            }
        }

        private void GrindBeans(int amount)
        {
            if (beansAmount < amount)
            {
                throw new InvalidOperationException("not enough coffee beans...");
            }
            Console.WriteLine("Grinding coffee beans..");
            beansAmount -= amount;
        }

        public void MakeEspresso()
        {
            HeatWater();
            GrindBeans(20);
            Console.WriteLine("Making Espresso....");
        }
        public void MakeLatte()
        {
            HeatWater();
            GrindBeans(25);
            Console.WriteLine("Making Latte....");
        }
        public int BeansLeft()
        {
            return beansAmount;
        }

        public int WaterLeft()
        {
            return waterAmount;
        }
    }
}
