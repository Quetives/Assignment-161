using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_161
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 12;
            MathFunction function = new MathFunction();

            function.functionOne(num1, num2);

            function.functionOne(int1: num1, int2: num2);

            Console.ReadLine();
        }
    }
}
