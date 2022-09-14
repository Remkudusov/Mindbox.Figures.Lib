using Figures.Models;
using Figures.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

namespace Figures.Tests
{
    [TestClass]
    public class FigureOperationsTests
    {
        [TestMethod]
        [Theory(DisplayName = "Найти площадь окружностей.")]
        public void ShouldFindRoundsArea()
        {
            var round1 = new Round() { Radius = 1 };
            var round2 = new Round() { Radius = 5 };
            var round3 = new Round() { Radius = 10 };

            Assert.AreEqual(Math.Round(round1.GetArea(), 2), 3.14);
            Assert.AreEqual(Math.Round(round2.GetArea(), 2), 78.54);
            Assert.AreEqual(Math.Round(round3.GetArea(), 2), 314.16);
        }

        [TestMethod]
        [Theory(DisplayName = "Найти площадь треугольников.")]
        public void ShouldFindTrianglesArea()
        {
            var triangle1 = new Triangle() { A = 24, B = 10, C = 26 };
            var triangle2 = new Triangle() { A = 5, B = 7, C = 8 };
            var triangle3 = new Triangle() { A = 8, B = 8, C = 8 };

            Assert.AreEqual(triangle1.GetArea(), 120);
            Assert.AreEqual(Math.Round(triangle2.GetArea(), 2), 17.32);
            Assert.AreEqual(Math.Round(triangle3.GetArea(), 2), 27.71);
        }
        
        [TestMethod]
        [Theory(DisplayName = "Являются ли треугольники прямоугольными.")]
        public void ShouldCheckIsTriangleRight()
        {
            var rightTriangle = new Triangle() { A = 24, B = 10, C = 26 };
            var notRightTriangle = new Triangle() { A = 5, B = 7, C = 8 };

            Assert.AreEqual(rightTriangle.IsRightTriangle(), true);
            Assert.AreEqual(notRightTriangle.IsRightTriangle(), false);
        }
    }
}