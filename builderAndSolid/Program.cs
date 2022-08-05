// See https://aka.ms/new-console-template for more information

using ConsoleApp2.DesignPattern.Builder;
using ConsoleApp2.DesignPattern.FacetedBuilderr;
using ConsoleApp2.DesignPattern.FluentBuilder;
using ConsoleApp2.DesignPattern.RecursiveGenericsFluentBuilder;
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

var BmwCar = carAssembler.CarBuild(new ConsoleApp2.DesignPattern.Builder.BMWBuilder());
Console.WriteLine($"car {nameof(BmwCar.name)} : {BmwCar.name} || {nameof(BmwCar.Color)} : {BmwCar.Color}");


//////////////////////
///FluentBuilder
///

CarBuilder BMWBuilder = new ConsoleApp2.DesignPattern.FluentBuilder.BMWBuilder();
var BmwCar2 = BMWBuilder.CreateName().CreateModel().CreateColor().GetCar();

Console.WriteLine($"car {nameof(BmwCar2.name)} : {BmwCar2.name} || {nameof(BmwCar2.Color)} : {BmwCar2.Color}");



////////////////////
///RecursiveGenericsFluentBuilder
///
BuildeDirector buildeDirector =new BuildeDirector();
var newcar = buildeDirector.SetColor("red").SetName("benz").SetModel("s500").SetSpeed("300").build();
Console.WriteLine($"car {nameof(newcar.name)} : {newcar.name} || {nameof(newcar.Color)} : {newcar.Model}");

//////////////////
///FacetedBuilder
///
CarBuilderFacade carBuilderFacade = new CarBuilderFacade();

var car3= carBuilderFacade.Info.WithColor("red").WithType("BMW").WithNumberOfDoors(4).Built.InCity("tehran").AtAddress("vanak").Build();

Console.WriteLine(car3.ToString());
