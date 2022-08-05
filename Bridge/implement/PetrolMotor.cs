using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.implement
{
    public class PetrolMotor : IMotor
    {
        public void CarMorot()
        {
            Console.WriteLine("The engine is Petrol burning");
        }
    }
}
