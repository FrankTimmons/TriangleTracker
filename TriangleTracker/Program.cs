using System;
using System.Collections.Generic;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("TRIANGLE TRACKER");
      Console.WriteLine("----------------");
      Console.WriteLine("Enter first number: ");
      string stringNum1 = Console.ReadLine();
      int num1 = int.Parse(stringNum1);

      Console.WriteLine("Enter second number: ");
      string stringNum2 = Console.ReadLine();
      int num2 = int.Parse(stringNum2);

      Console.WriteLine("Enter third number: ");
      string stringNum3 = Console.ReadLine();
      int num3 = int.Parse(stringNum3);

      Triangle triangle1 = new Triangle(num1, num2, num3);
    }
  }
}