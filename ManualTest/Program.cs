using Figures;

while (true)
{
    Console.WriteLine("Введите тип фигуры:");
    Console.WriteLine("Круг");
    Console.WriteLine("Треугольник");
    Console.WriteLine("Квадрат");
    Console.WriteLine("Прямоугольник");
    string shape = Console.ReadLine();

    var figure = new Figure();

    switch (shape.ToLower())
    {
        case "круг":
            figure = Circle.InputFigure();
            break;
        case "треугольник":
            figure = Triangle.InputFigure();
            break;
        case "квадрат":
            figure = Square.InputFigure();
            break;
        case "прямоугольник":
            figure = Rectangle.InputFigure();
            break;
        default:
            return;
    }
    Console.WriteLine(figure.ToString());
    Console.ReadLine();
    Console.Clear();
}