using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp97
{
    public class Display
    {
        string d = "This is the javascript";

        StringBuilder stringBuilder = new StringBuilder("This is the javascript");

        public void StringOperation()
        {
            stringBuilder.Replace("This", "That");

            Console.WriteLine(stringBuilder.ToString());
        }

        public int MathOperation(int a,out int b)
        {
            
            b= a/2;

            return a % b;
        }
    }
}
