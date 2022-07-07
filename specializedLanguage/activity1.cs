using System;

namespace MyApplication
{
  class Program
  {
    static void PrintPizzaArea()
    {
    float piVal;
    float pizzaDiameter;
    float pizzaRadius;
    float pizzaArea;
    
    piVal = 3.14159265f;
    pizzaDiameter = 12.0f;
    pizzaRadius = pizzaDiameter / 2.0f;
    pizzaArea = piVal * pizzaRadius * pizzaRadius;
    Console.WriteLine(pizzaDiameter + " in. pizza is " + Math.Round(pizzaArea, 3) + " sq. in.\n");
    }
    static void Main()
    {
    PrintPizzaArea();
    }
  }
}