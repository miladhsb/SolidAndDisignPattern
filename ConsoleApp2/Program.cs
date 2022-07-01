// See https://aka.ms/new-console-template for more information

using ConsoleApp2.Solid.OpenClose;

DiscountProduct discountProduct = new();
Console.WriteLine(discountProduct.GetProductPrice(25000));

DiscountProduct discountProduct2 = new(new GoldentUser());
Console.WriteLine(discountProduct2.GetProductPrice(25000));

DiscountProduct discountProduct3 = new(new silverUser());
Console.WriteLine(discountProduct3.GetProductPrice(25000));
