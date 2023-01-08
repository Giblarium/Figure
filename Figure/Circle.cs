namespace Figures
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius) 
        {
            Radius = radius;
            Area = radius * radius * Math.PI;
        }
        public override string ToString()
        {
            return $"Радиус круга: {Radius}\nПлощадь круга: {Area}";
        }
        public static Circle InputFigure()
        {
            Console.WriteLine("Введите радиус:");
            if (!Double.TryParse(Console.ReadLine(), out double _radius) || _radius < 0)
            {
                _radius = 0;
            }
            return new Circle(_radius);
        }
    }
}
