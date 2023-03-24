using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace PracticHome_008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задача 1
            var rectangle = new Rectangle(2,2);
            var triangle = new Triangle(2, 3, 5, 6, 7);
            var circle = new Circle(5);
            rectangle.PrintShape();
            triangle.PrintShape();
            circle.PrintShape();

            Figure[] figures = new Figure[5];
            figures[0] = new Rectangle(2,4);
            figures[1] = new Circle(5);
            figures[2] = new Triangle(2,3,5,6,7);
            figures[3] = new Rectangle(4,5);
            figures[4] = new Circle(3);

            foreach (Figure s in figures)
            {
                Console.WriteLine("Perimeter:\n " + s.Perimeter());
            }

            Console.WriteLine();

            // задача 2

            Director director = new Director();
            director.Position();
            Console.WriteLine("----------");
            Acountant acountant = new Acountant();  
            acountant.Position();
            Console.WriteLine("-----------");
            Worker worker = new Worker();   
            worker.Position();
            Console.WriteLine("-----------");

            Console.ReadKey();

            // задача 3


            SupplyContract document = new SupplyContract("123123", DateTime.Now, 1,10);;
            
            document.Date = DateTime.Now;
            Console.WriteLine(document);





        }








    }
}