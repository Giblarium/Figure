using Figures;

public class Rectangle : Figure
{
    public double A { get; set; }
    public double B { get; set; }
    public Rectangle(double a, double b)
    {
        A = a;
        B = b;
        Area = a * b;
    }
    public override string ToString()
    {
        return $"Стороны прямоугольника AB: {A}, {B}\nПлощадь прямоугольника: {Area}";
    }

    public static Rectangle InputFigure()
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
        return new Rectangle(_a, _b);
    }
}