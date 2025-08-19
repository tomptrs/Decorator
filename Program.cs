// See https://aka.ms/new-console-template for more information

using Decorator;

Decaf dc = new Decaf();
Console.WriteLine( dc.ToString());

Espresso espresso = new Espresso();
Console.WriteLine(espresso.ToString());

EspressoWithMilk espressoWithMilk= new EspressoWithMilk();
Console.WriteLine( espressoWithMilk.ToString());

DecafWithSoya decafWithSoya = new DecafWithSoya();
Console.WriteLine(decafWithSoya.ToString());
