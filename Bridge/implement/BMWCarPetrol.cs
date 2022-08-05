using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.implement
{
    public class BMWCarPetrol : Car
    {
        public BMWCarPetrol(IMotor motor) : base(motor)
        {
        }
    }
}
