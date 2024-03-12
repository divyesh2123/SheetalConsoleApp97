using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp97
{
    internal class RandomHelper
    {
        public static int randInt(int a,int b)
        {
            Random d = new Random();    

            return d.Next(a,b);
        }

        public static double randDouble(int a,int b)
        {
            Random random   = new Random();

            return random.NextDouble()*a+b;
        }
    }
}
