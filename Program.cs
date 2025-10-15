// See https://aka.ms/new-console-template for more information

using Decorator;

Beverage darkRoast = new DarkRoast() ;
darkRoast = new Milk(darkRoast);
darkRoast = new Milk(darkRoast);

Console.WriteLine(darkRoast.Description);
    Console.WriteLine(darkRoast.cost()) ;
