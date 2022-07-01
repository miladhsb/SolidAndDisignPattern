// See https://aka.ms/new-console-template for more information

using ConsoleApp2.DesignPattern.Builder;
using ConsoleApp2.Solid.OpenClose;

DiscountProduct discountProduct = new();
Console.WriteLine(discountProduct.GetProductPrice(25000));

DiscountProduct discountProduct2 = new(new GoldentUser());
Console.WriteLine(discountProduct2.GetProductPrice(25000));

DiscountProduct discountProduct3 = new(new silverUser());
Console.WriteLine(discountProduct3.GetProductPrice(25000));

///////////////////////////
///Builder
///
CarAssembler carAssembler = new CarAssembler();

var BmwCar = carAssembler.CarBuild(new BMWBuilder());
Console.WriteLine($"car {nameof(BmwCar.name)} : {BmwCar.name} || {nameof(BmwCar.Color)} : {BmwCar.Color}");


