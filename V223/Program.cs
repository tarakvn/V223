using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            double v1 = 1.3333333333 * Math.PI * radius;
            double v = Math.Pow(v1, 3);
            Console.WriteLine("The volume of the sphere is: " + v);
            Console.ReadKey();
        }
    }
}
