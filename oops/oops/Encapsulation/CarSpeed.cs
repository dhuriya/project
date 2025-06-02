using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Encapsulation
{
    public class CarSpeed
    {
        private int wheelRotations;
        private double gearRatio = 4.2;
        private const double WHEEL_CIRCUMFERENCE = 2.0;

        public CarSpeed()
        {
            wheelRotations = 0;
        }


        private void Move()
        {
            wheelRotations++;
        }

        private double CalculateSpeed()
        {
            double distanceCovered = wheelRotations * WHEEL_CIRCUMFERENCE;
            double time = 1.0;
            return (distanceCovered * gearRatio) / time;
        }

        public void Drive()
        {
            Move();
            Console.WriteLine("Current Speed " + CalculateSpeed());
        }
        public void ResetSpeedometer()
        {
            wheelRotations = 0;
        }
    }
}
