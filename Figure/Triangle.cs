using System.Runtime.ExceptionServices;

namespace Figure
{
    internal class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        /// <summary>
        /// Создание фигуры треугольника и вычисление площади по трем сторонам.
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        /// <exception cref="TriangleDoesNotExistException">Неверные стороны (сумма двух сторон должна быть больше третьей)</exception>
        public Triangle(double a, double b, double c)
        {
            if (a + b < c || a + c < b || b + c < a)
            {
                throw new TriangleDoesNotExistException(); // треугольника с такими сторонами существовать не может
            }
            A = a;
            B = b;
            C = c;
            double p = (a + b + c) / 2;
            Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //формула Герона для площади через полупериметр
        }
        public override string ToString()
        {
            return $"Стороны трегугольника ABC: {A}, {B}, {C}/nПлощадь треугольника: {Area}";
        }
    }
}
