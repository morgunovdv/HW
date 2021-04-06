using System;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {

            Point x = new Point(30, 40, "X");
            Point y = new Point(60, 80, "Y");
            Point z = new Point(90, 110, "Z");

            Point a = new Point(int.Parse(Console.ReadLine()), 4, "A");


            Polygon triangle = new Polygon(x, y, z);

            string name = triangle.GetName();

            Console.WriteLine($"Ваша фигура: {name}");
        }
    }
}
