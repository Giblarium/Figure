
namespace Figures
{
    public class Triangle : Figure
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
            return $"Стороны трегугольника ABC: {A}, {B}, {C}\nПлощадь треугольника: {Area}";
        }

        public static Figure InputFigure()
        {
            Console.WriteLine("Введите сторону A:");
            if (!Double.TryParse(Console.ReadLine(), out double _a) || _a < 0)
            {
                _a = 0;
            }
            Console.WriteLine("Введите сторону B:");
            if (!Double.TryParse(Console.ReadLine(), out double _b) || _b < 0)
            {
                _b = 0;
            }
            Console.WriteLine("Введите сторону B:");
            if (!Double.TryParse(Console.ReadLine(), out double _c) || _c < 0)
            {
                _c = 0;
            }
            return new Triangle(_a, _b, _c);
        }
    }
}
