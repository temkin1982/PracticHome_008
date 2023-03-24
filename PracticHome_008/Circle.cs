namespace PracticHome_008
{
    class Circle : Figure
    {
        public double Radius { get; set; }
      
        public override double GetArea() => Math.PI * Radius * Radius;
        
        
        public Circle(double r)
        {
            Radius = r;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public void PrintShape()
        {
            Console.WriteLine($"Circle :\n Perimeter: {Perimeter()}  Area: {GetArea()}");
        }
        


    }
    
}
