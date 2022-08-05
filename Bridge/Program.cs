using Bridge.implement;
using System;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car BmwGas = new BMWCarGas(new GasMotor());
            BmwGas.Drive();
            Car BmwPetrol = new BMWCarGas(new PetrolMotor());
            BmwPetrol.Drive();

        }
    }
}
