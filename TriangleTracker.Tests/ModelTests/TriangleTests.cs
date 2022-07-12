using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleChecker_ChecksIfEquilateral_Equilateral()
    {
      Triangle newTriangle = new Triangle(3,3,3);
      Assert.AreEqual("Equilateral", newTriangle.TriangleChecker());
    }
  }
}