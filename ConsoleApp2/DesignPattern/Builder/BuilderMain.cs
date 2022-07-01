using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DesignPattern.Builder
{


    public abstract class IBuilder
    {
        protected Car car { get; set; }=new Car();
        public abstract void CreateName();
        public abstract void CreateModel();
        public abstract void CreateColor();

        public Car GetCar()
        {
            return car;
        }

    }

    public class BMWBuilder : IBuilder
    {
        public override void CreateColor()
        {
            car.Color = "red";
        }

        public override void CreateModel()
        {
            car.Model = "2022";
        }

        public override void CreateName()
        {
            car.name = "X6 M Sports Activity";
        }
    }


    public  class CarAssembler
    {
      
        public Car CarBuild(IBuilder builder)
        {
            builder.CreateName();
            builder.CreateModel();
            builder.CreateColor();
            return builder.GetCar();
        }
    }


}
