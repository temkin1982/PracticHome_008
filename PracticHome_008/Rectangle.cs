namespace PracticHome_008
{
    class Rectangle : Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }

        double width;
        double height;
        
        public Rectangle(double w, double h)
        {
                width = w;
                height = h;
        }
        public override double GetArea()
        {
            return width * height;
        }

        public override double Perimeter()
        {
                return 2 * (width + height);
           
        }
        public void PrintShape()
        {
            Console.WriteLine($"Rectangle :\n Perimeter: {Perimeter()}  Area: {GetArea()}");

        }




             
    }
}
