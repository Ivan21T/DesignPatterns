using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public static class InterpreterClass
    {
        public static void Аdd(double a,double b)
        {
            Console.WriteLine("{0} + {1} = {2}",a,b,a+b);
        }
        public static void Subtraction(double a,double b)
        {
            Console.WriteLine("{0} - {1} = {2}",a,b,a-b);
        }
        public static void Multiplication(double a,double b)
        {
            Console.WriteLine("{0} x {1} = {2}",a,b,a*b);
        }
        public static void Division(double a,double b)
        {
            Console.WriteLine("{0} / {1} = {2}",a,b,a/b);
        }
    }
}
