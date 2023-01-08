using Figures;

public class Square : Figure
{
    public double A { get; set; }

    public Square(double a)
    {
        A = a;
        Area = a * a;
    }

    public static Figure InputFigure()
    {
        Console.WriteLine("Введите сторону A:");
        if (!Double.TryParse(Console.ReadLine(), out double _a) || _a < 0)
        {
            _a = 0;
        }
        return new Square(_a);
    }
    public override string ToString()
    {
        return $"Стороны квадрата A: {A}\nПлощадь квадрата: {Area}";
    }
}