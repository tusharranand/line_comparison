using System;

namespace line_comparison_probelm
{
    class program
    {
        static int Enter(string coordinate)
        {
            Console.Write("Enter the value for {0}: ", coordinate);
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program.");
           
            Console.WriteLine("For the first line,");

            int x1 = Enter("x1");
            int y1 = Enter("y1");
            int x2 = Enter("x2");
            int y2 = Enter("y2");

            Console.WriteLine("Coordinates for the given line are: ");
            Console.WriteLine("({0},{1}) and ({2},{3})", x1, y1, x2, y2);
            float len_first = (float)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of given line = {0} units", len_first);

            Console.WriteLine("\nFor the second line,");

            int x3 = Enter("x1");
            int y3 = Enter("y1");
            int x4 = Enter("x2");
            int y4 = Enter("y2");

            Console.WriteLine("Coordinates for the given line are: ");
            Console.WriteLine("({0},{1}) and ({2},{3})", x3, y3, x4, y4);
            float len_sec = (float)Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of given line = {0} units\n", len_sec);

            if (len_sec == len_first)
            {
                Console.WriteLine("Both lines are equal in length.");
            }
            else
            {
                Console.WriteLine("Both lines are not equal in length.");
            }
        }
    }
}