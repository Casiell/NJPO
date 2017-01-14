using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy
{
    public class Program
    {
        public static double a, b, c;

        public static void Main(string[] args)
        {
            Console.WriteLine("Równanie kwadratowe ma postać: ax^2 + bx + c");
            LoadNumbers();
            CalculateRoots(CalculateDelta());
            Console.ReadKey();
        }

        public static void LoadNumbers()
        {
            Console.Write("Podaj a: ");

            while (!double.TryParse(Console.ReadLine().ToString(), out a))
            {
                Console.Write("Podaj a: ");
            };

            Console.Write("Podaj b: ");
            while (!double.TryParse(Console.ReadLine().ToString(), out b))
            {
                Console.Write("Podaj b: ");
            };

            Console.Write("Podaj c: ");
            while (!double.TryParse(Console.ReadLine().ToString(), out c))
            {
                Console.Write("Podaj c: ");
            };
        }

        public static double CalculateDelta()
        {
            //Console.Write("\na = {0}, b = {1}, c = {2}", a, b, c);
            double delta = Math.Pow(b, 2) - (4 * a * c);
            Console.Write("\nDelta = " + delta);
            return delta;
        }

        public static void CalculateRoots(double delta)
        {
            if (delta > 0)
            {
                double root1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("\nx1 = {0}\nx1 = {1}", root1, root2);
            }
            else if (delta == 0)
            {
                double root = (-b) / (2 * a);
                Console.WriteLine("\nx = " + root);
            }
            else
            {
                Console.WriteLine("\nNie ma pierwiastków rzeczywistych tego równania.");
            }
        }
    }
}