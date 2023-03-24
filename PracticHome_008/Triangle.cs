namespace PracticHome_008
{
    class Triangle : Figure
    {
        public double Foundation { get; set; }
        public double Width { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double side1, double side2, double side3, double foundatio, double width)
        {
            A = side1;
            B = side2;
            C = side3;
            Foundation = foundatio;
            Width = width;
        }
        public override double GetArea()
        {
            return Foundation * Width * 0.5;
        }
        public override double Perimeter()
        {
           return A + B + C;
        }
        public void PrintShape()
        {
            Console.WriteLine($"Triangle :\n Perimeter: {Perimeter()}  Area: {GetArea()}");
        }
    }
}
