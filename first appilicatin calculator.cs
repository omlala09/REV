using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Number: ");
            int first = Int32.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int Second= Int32.Parse(Console.ReadLine());
            int result= first + Second;
            Console.WriteLine(first + "+"+ Second+"="+result);
            result = first - Second;
            Console.WriteLine(first + "-"+ Second +"="+result);
            result = first / Second;
            Console.WriteLine(first + "/" + Second + "=" + result);
            result = first * Second;
            Console.WriteLine(first + "*" + Second + "=" + result);
        }
    }
}

