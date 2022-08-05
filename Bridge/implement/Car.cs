using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.implement
{
    public abstract class Car
    {
        private readonly IMotor motor;

        public Car(IMotor motor)
        {
            this.motor = motor;
        }

        public void Drive()
        {
         motor.CarMorot();
        }
    }
}
