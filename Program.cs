using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{

    
    public delegate float operation(int x, int y);
    class Program
    {
        static float add(int a, int b)
        {
            return a + b;
        }
        static float subtract(int c, int d)
        {
            if (c < d)
            {
                return d - c;
            }
            else
            {
                return c - d;
            }
        }
        static float multiply(int m, int v)
        {
            return m * v;
        }
        static float Divide(int divisor, int divident)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return divident / divisor;
            }

        }
        static void Main(string[] args)
        {
            operation obj = new operation(Program.add);
            operation obj1 = new operation(Program.subtract);
            operation obj2 = new operation(Program.multiply);
            operation obj3 = new operation(Program.Divide);
            Console.WriteLine("enter two numbers");
            int val1 = Convert.ToInt16(Console.ReadLine());
            int val2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Addition of {0} + {1} = {2}", val1, val2, obj(val1, val2));
            Console.WriteLine("Subtraction of  {0} and {1} is {2}", val1, val2, obj1(val1, val2));
            Console.WriteLine("Division of  {0} and {1} is {2}", val1, val2, obj3(val1, val2));
            Console.WriteLine("Multiplication of {0} and {1} is {2}", val1, val2, obj2(val1, val2));
            Console.ReadLine();



        }
    }
}
