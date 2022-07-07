using System;

namespace MyApplication
{
  class Program
  {
    static void PrintPizzaArea(float pizzaDiameter)
	{
    float piVal;
    float pizzaRadius;
    float pizzaArea;
    
    piVal = 3.14159265f;
    pizzaRadius = pizzaDiameter / 2.0f;
    pizzaArea = piVal * pizzaRadius * pizzaRadius;
    Console.WriteLine(pizzaDiameter + " in. pizza is " + Math.Round(pizzaArea, 3) + " sq. in.\n");
    }
    static void Main()
    {
    PrintPizzaArea(12.0f);
    PrintPizzaArea(16.0f);
    }
  }
}