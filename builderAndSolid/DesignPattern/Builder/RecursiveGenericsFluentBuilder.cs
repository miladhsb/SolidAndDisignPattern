using ConsoleApp2.DesignPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DesignPattern.RecursiveGenericsFluentBuilder
{


    public abstract class BaseBuilder
    {
        protected Car _Car;
        public BaseBuilder()
        {
            _Car = new Car();
        }

        public Car build()
        {
            return _Car;
        }

    }

    public class CarColor<T> : BaseBuilder where T : CarColor<T>
    {

        public T SetColor(string color)
        {
            _Car.Color = color;
            return (T)this;
        }
    }

    public class CarName<T> : CarColor<CarName<T>> where T : CarName<T>
    {

        public T SetName(string name)
        {
            _Car.name = name;
            return (T)this;
        }
    }
    public class CarModel<T> : CarName<CarModel<T>> where T : CarModel<T>
    {

        public T SetModel(string model)
        {
            _Car.Model = model;
            return (T)this;
        }
    }

    public class CarSpeed<T> : CarModel<CarSpeed<T>> where T : CarSpeed<T>
    {

        public T SetSpeed(string speed)
        {
           // _Car.Model = model;
            return (T)this;
        }
    }
    public class BuildeDirector: CarSpeed<BuildeDirector>
    {
        public static BuildeDirector CarBuilder => new ();
    }



}
