using ConsoleApp2.DesignPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DesignPattern.FluentBuilder
{


    public abstract class CarBuilder
    {
        protected Car car { get; set; }=new Car();
        public abstract CarBuilder CreateName();
        public abstract CarBuilder CreateModel();
        public abstract CarBuilder CreateColor();

        public Car GetCar()
        {
            return car;
        }

    }

    public class BMWBuilder : CarBuilder
    {
        public override CarBuilder CreateColor()
        {
            car.Color = "red";
            return this;
        }

        public override CarBuilder CreateModel()
        {
            car.Model = "2022";
            return this;
        }

        public override CarBuilder CreateName()
        {
            car.name = "X3 Sports Activity";
            return this;
        }
    }


  


}
