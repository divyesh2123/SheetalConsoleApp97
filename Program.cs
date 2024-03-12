using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp97
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    RandomHelper random = new RandomHelper();

        //   var p = RandomHelper.randInt(2, 3);
        //    Console.WriteLine(p);

        //    var t = RandomHelper.randDouble(1, 10);
        //Console.WriteLine(t);


            Display d = new Display();
            d.StringOperation();

            int b = 2;
           var p = d.MathOperation(4, out b);

            Console.WriteLine(b);
            Console.WriteLine(p);


            Console.ReadKey();
        }
    }
}
