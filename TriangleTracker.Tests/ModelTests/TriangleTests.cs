using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleChecker_ChecksTriangleType_Equilateral()
    {
      Triangle newTriangle = new Triangle(3,3,3);
      Assert.AreEqual("Equilateral", newTriangle.TriangleChecker());
    }

    [TestMethod]
    public void TriangleChecker_ChecksTriangleType_Isosceles()
    {
      Triangle newTriangle = new Triangle(3,3,1);
      Assert.AreEqual("Isosceles", newTriangle.TriangleChecker());
    }

    [TestMethod]
    public void TriangleChecker_ChecksTriangleType_Scalene()
    {
      Triangle newTriangle = new Triangle(3,2,1);
      Assert.AreEqual("Scalene", newTriangle.TriangleChecker());
    }
  }
}