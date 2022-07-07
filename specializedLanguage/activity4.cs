using System;
namespace MyApplication
{
  class Program
  {
    static int ComputerSquare(int numToSquare)
    {
    int numSquared;
    numSquared = numToSquare * numToSquare;
    return numSquared;
    }
    static void Main()
    {
    int squaredVal;
    squaredVal = ComputerSquare(7);
    Console.WriteLine(squaredVal);
    }
  }
}