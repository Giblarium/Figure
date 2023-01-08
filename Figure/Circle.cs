namespace Figure
{
    internal class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double radius) 
        {
            Radius = radius;
            Area = radius * radius * Math.PI;
        }
        public override string ToString()
        {
            return $"Площадь круга: {Area}/nРадиус круга: {Radius}";
        }
    }
}
