using System;

namespace TriangleTracker.Models
{
  public class Triangle 
  {
    private int _side1;
    private int _side2;
    private int _side3;

    public Triangle(int num1, int num2, int num3)
    {
      _side1 = num1;
      _side2 = num2;
      _side3 = num3;
    }

    public string TriangleChecker()
    {
      if (_side1 > (_side2 + _side3) || _side2 > (_side1 + _side3) || _side3 > (_side1 + _side2))
      {
        return "Invalid Triangle";
      }
      else if (_side1 == _side2 && _side1 == _side3)
      {
        return "Equilateral";
      }
      else if (_side1 == _side2 || _side1 == _side3  || _side2 == _side3)
      {
        return "Isosceles";
      }
      else
      {
        return "Scalene";
      }
    }
  }
}