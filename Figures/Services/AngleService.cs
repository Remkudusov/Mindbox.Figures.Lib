using Figures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Services
{
    /// <summary>
    /// Сервис для операций с углами.
    /// </summary>
    public static class AngleService
    {
        /// <summary>
        /// Метод для проверки того, что треугольник - прямоугольный.
        /// </summary>
        /// <param name="triangle">Объект треугольника.</param>
        /// <returns>Является ли треугольник прямоугольным.</returns>
        public static bool IsRightTriangle(this Triangle triangle)
        {
            return Math.Pow(triangle.C, 2) == Math.Pow(triangle.A, 2) + Math.Pow(triangle.B, 2);
        }
    }
}
