using System;

namespace CircleProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c1 = new Circle(2.25);
            Console.WriteLine(c1);
            Circle c2 = new Circle(4);
            c2.Radius = 4.05;
            Console.WriteLine(c2);

            if (c1.Area > c2.Area)
                Console.WriteLine("A nagyobb területű kör kerülete:" + c1.District);
            else if (c2.Area > c1.Area)
                Console.WriteLine("A nagyobb területű kör kerülete:" + c2.District);
            else
                Console.WriteLine("A két kör területe megegyezik! Kerületük:" + c1.District);

        }
    }
}
