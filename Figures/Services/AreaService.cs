using Figures.Models;

namespace Figures.Services
{
    /// <summary>
    /// Сервис для нахождения площади фигур.
    /// </summary>
    public static class AreaService
    {
        /// <summary>
        /// Метод для поиска площади круга по радиусу.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        /// <returns>Площадь круга.</returns>
        public static double GetArea(this Round round)
        {
            return Math.Pow(round.Radius, 2) * Math.PI;
        }

        /// <summary>
        /// Метод для поиска площади треугольника по трём сторонам.
        /// </summary>
        /// <param name="a">Длина стороны A.</param>
        /// <param name="b">Длина стороны B.</param>
        /// <param name="c">Длина стороны C.</param>
        /// <returns>Площадь треугольника.</returns>
        public static double GetArea(this Triangle triangle)
        {
            var p = (triangle.A + triangle.B + triangle.C) / 2;
            return Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));
        }
    }
}
