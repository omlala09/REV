//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace VariablesTutorial
//{
//class program
//{
//    static void Main(string[] args)
//    {
//        int ourNumber;
//        ourNumber = 0;
//        Console.WriteLine(ourNumber);
//        ourNumber = 10;
//        Console.WriteLine(ourNumber);
//        ourNumber = 2+2;
//        Console.WriteLine(ourNumber);
//        double decimalNumber;
//        decimalNumber = 10.15;
//        Console.WriteLine(decimalNumber);
//        int number = 5;

//        char myCharacter = 'C';
//        Console.WriteLine(myCharacter);

//        string myName = "OM";
//        Console.WriteLine(myName);

//        int newVariable = ourNumber- number;
//        Console.WriteLine(newVariable);

//        Boolean temp = true;
//        Console.WriteLine(temp);

//namespace ifstatement
//{
//  class Program
//  {
//      static void Main(string[] args)
//      {
//          int biggernumber = 10;
//          int smallernumber = 1;

//          Console.WriteLine("1.condition");
//          if (biggernumber != smallernumber)
//          {
//              Console.WriteLine(biggernumber + "is not equal to " + smallernumber);

//          }
//          Console.WriteLine("2.condition");
//          if (biggernumber == smallernumber)
//          {
//              Console.WriteLine(biggernumber + "is equal " + smallernumber);

//          }
//          else
//          {
//              Console.WriteLine("Else");
//          }

//          Console.WriteLine("3.condition");
//          if (biggernumber > smallernumber)
//          {
//              Console.WriteLine(biggernumber + "is greater than " + smallernumber);
//          } else if (biggernumber != smallernumber)
//          {
//              Console.WriteLine(biggernumber + "is not equal to " + smallernumber);

//          } else
//          { Console.WriteLine("else");
//          }
//          Console.WriteLine("4.condition");
//          if (biggernumber > smallernumber)

//          {
//              Console.WriteLine(biggernumber + " is greater than " + smallernumber);

//          }
//          else
//          {
//              Console.WriteLine("else");

//          }

//          Console.WriteLine("5.condition");
//          if (biggernumber <= smallernumber)
//          {
//              Console.WriteLine("biggernumber is  smaller");
//          }
//          else if (biggernumber == smallernumber)
//          {
//              Console.WriteLine("they are equal");
//          }
//          else if (biggernumber != smallernumber)
//          {
//              Console.WriteLine("they are not equal");
//          }
//          else if (biggernumber > smallernumber)
//          {
//              Console.WriteLine("bigger is greater");
//          }

//          Console.WriteLine("6.condition");
//          if (biggernumber <= smallernumber)
//          {
//              Console.WriteLine("biggernumber is  smaller");
//          }
//          if (biggernumber == smallernumber)
//          {
//              Console.WriteLine("they are equal");
//          }
//          if (biggernumber != smallernumber)
//          {
//              Console.WriteLine("they are not equal");
//          }
//          if (biggernumber > smallernumber)
//          {
//              Console.WriteLine("biggernumber is greater");

//          }
//          Console.WriteLine("7.condition");
//          if ((biggernumber > smallernumber) && (biggernumber < smallernumber))
//          {
//              Console.WriteLine("first");
//          }
//          else if ((biggernumber > smallernumber) && (!(biggernumber < smallernumber)))

//          {
//              Console.WriteLine("second");
//          }
//          else
//          {
//              Console.WriteLine("else");
//          }
//          Console.WriteLine("8.condition");
//          if ((biggernumber > smallernumber) || (biggernumber < smallernumber))
//          {
//              Console.WriteLine("first");
//          }
//          else if ((biggernumber > smallernumber) || (!(biggernumber < smallernumber)))

//          {
//              Console.WriteLine("second");
//          }
//          else
//          {
//              Console.WriteLine("else");
//          }



//      }
//  }
//}

//namespace SwitchTutorial
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            int swiched = 7;
//            int result = 0;
//            switch (swiched)
//            {
//                case 1:
//                    result= 10;
//                    break;
//                case 3: 
//                    result= 30; 
//                    break;
//                case 5:
//                    result= 50;
//                    break;
//                default:
//                    result = 100;
//                    break;



//            }
//            if (1 == swiched)
//            {
//                result = 10;
//            }else if (3 == swiched)
//            {
//                result = 30;
//            }
//            else if (5 == swiched)
//            {
//                result = 50;
//            }
//            else
//            {
//                result = 100;
//            }
//            Console.WriteLine(result);
//        }
//    }
//}


//namespace ArrayTutorial
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] ages = { 10, 5, 12, 20, 18 };
//            Console.WriteLine("Number on index 0: " + ages[0]);
//            int onIndex2 = ages[2];
//            Console.WriteLine ("age on index 2: " + onIndex2);
//            ages[2] = ages[2] + 1;
//            Console.WriteLine("age on index 2: " + ages[2]);
//            Console.WriteLine("onIndex2 ; " + onIndex2);

//            string[] names = { "OM", "John", "Doe", "OM" };
//            string name = names[1];
//            names[1] = "Jane";
//            Console.WriteLine(name);
//            Console.WriteLine(names[1]);

//        }
//    }
//}
//namespace Forloop
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int temp = 1;
//            temp++;
//            Console.WriteLine(temp);
//            temp--;
//            Console.WriteLine(temp);

//            Console.WriteLine("1.loop");
//            for (int i = 5; i > 0; i--)
//            {
//                Console.WriteLine("Value of i is :" + i);

//            }
//            Console.WriteLine("2.loop");
//            string[] names = {"OM", "John", "Doe", "OM"};
//            for (int i = 0; i < names.Length; i++)
//            {
//                Console.WriteLine(" Value on index " + i + " is equal to " + names[i]);

//            }
//            Console.WriteLine("i");

//        }
//    }
//}

//namespace Whileloop
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {  
//           int temp = 0;
//           while (temp < 5)
//           {
//                if (temp > 3)
//                {

//                    break;
//                }
//                temp++;

//           }
//           Console.WriteLine(temp);

//            int[] arr = { 10, 5, 12, 20, 18 };
//            int i = 0;
//            while(i<arr.Length)

//            {
//                Console.WriteLine(arr[i]);
//                i++;
//            }


//        }
        
//    }
//}


//namespace dowhileloop
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i = 10;
//            do
//            {
//                i++ ;
//            } while (i<0);
//            Console.WriteLine(i);

//            while (i < 0)
//            {
//                i++;
//            }
//            Console.WriteLine(i);
//        }
//    }
//}

namespace FunctionsTutorial
{
    class Program
    {
        public static int squared(int x)
        {
            int y = x * x;
            return y;
        }
        public static void printNumber(int number)
        {
            Console.WriteLine("Number: " + number);
        }
        public static Boolean isBigger(int first , int second)
        {
            Boolean temp = first> second;
            return temp;
        }
        static void Main(string[] args)
        {
            int temp = 10;
            int result = squared(temp);
            printNumber(temp);
            printNumber(result);
            Console.WriteLine(isBigger(10, 20));
            if(isBigger(20,10))
            {
                printNumber(result);
            }


        }

    }
}