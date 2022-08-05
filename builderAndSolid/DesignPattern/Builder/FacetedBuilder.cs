using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DesignPattern.FacetedBuilderr
{


    public class Car
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }

        public string City { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"CarType: {Type}, Color: {Color}, Number of doors: {NumberOfDoors}, Manufactured in {City}, at address: {Address}";
        }
    }


    public class CarBuilderFacade
    {
        protected Car _Car { get; set; }

        public CarBuilderFacade()
        {
            _Car = new Car();
        }

        public Car Build() => _Car;

        public CarInfoBuilder Info => new CarInfoBuilder(_Car);
        public CarAddressBuilder Built => new CarAddressBuilder(_Car);
    }

    public class CarInfoBuilder : CarBuilderFacade
    {
        public CarInfoBuilder(Car car)
        {
           _Car = car;
        }

        public CarInfoBuilder WithType(string type)
        {
            _Car.Type = type;
            return this;
        }

        public CarInfoBuilder WithColor(string color)
        {
            _Car.Color = color;
            return this;
        }

        public CarInfoBuilder WithNumberOfDoors(int number)
        {
            _Car.NumberOfDoors = number;
            return this;
        }
    }


    public class CarAddressBuilder : CarBuilderFacade
    {
        public CarAddressBuilder(Car car)
        {
            _Car = car;
        }

        public CarAddressBuilder InCity(string city)
        {
            _Car.City = city;
            return this;
        }

        public CarAddressBuilder AtAddress(string address)
        {
            _Car.Address = address;
            return this;
        }
    }






}
