using System;
namespace MyApplication
{
  class Program
  {
    static float CircleArea(float circleDiameter)
    {
    float circleRadius;
    float piVal;
    float circleArea;
    
    piVal = 3.14159265f;
    circleRadius = circleDiameter / 2.0f;
    circleArea = piVal * circleRadius * circleRadius;
    
    return circleArea;
    }
    static float PizzaCalories(float pizzaDiameter)
    {
    float caloriesPerSquareInch;
    float totalCalories;
    
    // Regular crust pepperoni pizza
    caloriesPerSquareInch = 16.7f;
    totalCalories = CircleArea(pizzaDiameter) * caloriesPerSquareInch;
    
    return totalCalories;
    }
    static void Main()
    {
    int pizzaDiameter;
    
    pizzaDiameter = 12;
    
    Console.WriteLine(pizzaDiameter + " inch pizza has " + PizzaCalories(pizzaDiameter) + " calories.\n");
    }
  }
}