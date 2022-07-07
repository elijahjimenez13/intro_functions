using System;
namespace MyApplication
{
  class Program
  {
    static float HeightFtInToCm(int heightFt, int heightIn)
    {
    float cmPerInch;
    int inchesPerFeet;
    int totalInches;
    float heightCm;
    
    cmPerInch = 2.54f;
    inchesPerFeet = 12;
    
    // Total Inches
    totalInches = (heightFt * inchesPerFeet) + heightIn;
    
    // Convert Inches to Cm
    heightCm = totalInches * cmPerInch;
    
    return heightCm;
    }
    static void Main()
    {
    int userFt;
    int userIn;
    
    userFt = 5;
    userIn = 8;
    
    Console.WriteLine("Centimeters: " + HeightFtInToCm(userFt, userIn));
    }
  }
}