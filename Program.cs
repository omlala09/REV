//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace Hello
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//Single line Comment Example - this is important for debugging. do Not remove

/* this is a multiline comment example 
 spanning multiple line*/

//int om = 15; //integer variable
//string inp = Console.ReadLine();
//Console.WriteLine(inp);
//Console.WriteLine("HELLO WORLD");
//Console.Write("HELLO OM");
//Console.WriteLine("I LOVE C#" + om );

/*data types in c# :
 * Integer - int om;-->4 bytes
 * Long - long om ; --> 8 bytes 
 * Floating point number - float that;-->4 bytes
 * Double - double om ; --> 8 bytes
 * Character - char a = 'A';-->2 bytes 
 * Boolean - bool isGreat = true;-->1 bit
 * string inp = "Harry";--> 2 bytes per character
 */

//Data Types Examples 

//int a = 55;
//float b = 55.4F;
//double c = 55.4D;
//bool isGreat = true;
//char d = 'r';
//string e = "this is a string";
//double b = 55.4;



//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(isGreat);
//Console.WriteLine(d);
//Console.WriteLine(e);

// Type Casting
// There are two types of type casting 
//1. Implicit Casting
// char to int to long to float to double 

//2. Explicit Casting 

//int x = (int) 3.5;
//double  x1 = (double) 3.5;
//Console.WriteLine(x1);
//Console.ReadLine();

           
//        }
//    }
//}


//using System;
//using System.Reflection.Metadata.Ecma335;

//namespace Hello
//{
//    class Program
//    {
//        static void Main(string[] args)
        //{
            //// Implicit Casting
            //int x = 3;
            //double y = x;
            //int z = 'y';
            //float a = '1';

            //float xa = Convert.ToInt32(3.55);
            //string sa = "34 is amazing";

            //long varr = Convert.ToInt64(3.55);
            //string sx = "Random string";

            //float ax1 = 34.4f;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(xa);
            //Console.WriteLine(sa);
            //Console.WriteLine(varr);
            //Console.WriteLine(sx);
            //Console.WriteLine(ax1);

            //Console.WriteLine("Enter your Name");
            //string name= Console.ReadLine();
            //Console.WriteLine("Hey hello " + name );
            //Console.WriteLine("How many candies do you want?");
            //string can  = Console.ReadLine();
            //Console.WriteLine("You will get 4 more candies " + 
            //    (Convert.ToInt32(can) + 4 ));

            //Operators in C#
            /*1.Arithmetic operators
             *2 Assignment Operators 
             *3 Logical Operators
             *4 Comparsion Operators 
             */

            //int a = 4;
            //int b = 2;
            //Console.WriteLine("The value of a + b is : " + (a + b));
            //Console.WriteLine("The value of a - b is : " + (a - b));
            //Console.WriteLine("The value of a * b is : " + (a * b));
            //Console.WriteLine("The value of a / b is : " + (a / b));



            //Assignment Operators
            //int a = 4;
            //int b = a;
            //b -= 4;
            //b += 4;
            //b /= 4;
            //b *= 4;

            //Console.WriteLine(b);



            //Logical Operators 
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true|| false); 
            //Console.WriteLine(true|| true);
            //Console.WriteLine(false|| false);

            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            //Comparison Operators 
            //Console.WriteLine(324 > 555);
            //Console.WriteLine(324 <= 555);
            //Console.WriteLine(324 >= 555);
            //Console.WriteLine(324 != 555);
            //Console.WriteLine(324 == 555);



            //Console.ReadLine();


            //int a = Math.Max(34, 345);
            //Console.WriteLine(a);
            //Console.ReadLine();

            //double  a = Math.Sqrt(39);

            //int a = Math.Abs(+39);

            //Console.WriteLine(a);

            //string hello = "Hello world this is OM ";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello + "You are nice ");
            //Console.WriteLine(string.Concat(hello , "You are nice "));

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name}.You will get {candies} candies");

            //string hello = "Hello world this is OM ";
            ////Console.WriteLine(hello[0]);
            ////Console.WriteLine(hello[1]);
            //Console.WriteLine(hello.IndexOf("Hello"));


            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.Substring(1));
            //Console.WriteLine(hello.Substring(5));
            //Console.WriteLine(hello);

            //Escape sequence character

            //string hello = "Hello world this \t is OM ";
            //string hello = "Hello world this \" is OM ";






            //int age = 56;
            //if (age > 18)
            //{
            //    Console.WriteLine("You can drive");

            //}

            //else
            //{
            //    Console.WriteLine("You cannot drive");

            //}

            //Console.WriteLine("Enter your age");

            //string ageStr = Console.ReadLine();

            //int age = Convert.ToInt32(ageStr);
            //bool isBanned = true;
            //if (age < 2 || isBanned )
            //{
            //    Console.WriteLine("You are just born or banned ");

            //}
            //else if (age<10 || isBanned)
            //{
            //    Console.WriteLine("Please finish your high school or maybe you are banned");

            //}
            //else if (age < 18)
            //{
            //    Console.WriteLine("You are below 18");

            //}
            //else if (age < 75)
            //{
            //    Console.WriteLine("You can Drive");
            //}

            //else
            //{
            //    Console.WriteLine("You cannot drive");

            //}

            //int age = 78;

            //switch(age)
            //{
            //    case 18:
            //        Console.WriteLine("Please wait for an year");
            //        break;

            //    case 20: Console.WriteLine("You are 20");
            //        break;

            //    default:
            //        Console.WriteLine("Enjoy!");
            //        break;

            //}


            //Loops in C sharp
            //Console.WriteLine(1);
            //Console.WriteLine(2); 
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);

            //Better Alternative - Loops
            //while loops

            //int i = 0;
            //while (i < 5000)
            //{
            //    Console.WriteLine(i+1);
            //    i++;
            //}

            // do while loop
            //int i = 0;

            //do
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //} while (i < 5);

            //for loop

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 0)
            //    continue;
            //    Console.WriteLine(i + 1);
            //    //break;
            //}

//Break and continue
//break - leave this loop forever;
//Continue: Leave this particular iteration of the loop








//            Console.ReadLine();








//        }


//    }
//}

//Console.WriteLine("Hello, World!");

using System;
//namespace Hello
//{
//    class Program
//    {
//        static void Greet(string name)
//        {
//            Console.WriteLine("Good Morning" + name );

//        }

//        static void Main(string[] args)
//        {

//            Greet("OM");
//            Greet("Rohan");
//            Console.ReadLine();
//        }
//    }
//}


//namespace Hello
//{
//    class Program
//    {
//        static void Greet(string name)
//        {
//            Console.WriteLine("Good Morning" + name );

//        }
//        static float Average(int a, int b, int c)
//        {
//            int sum = a + b + c;
//            return sum / 3;
//        }

//        static float Average(int a , int b )
//        {
//            return ( a + b )/2 ;
//        }

//        static void Main(string[] args)
//        {

//            Greet("OM");
//            Greet("Rohan");
//            Console.WriteLine(Average(2, 6, 8));
//            float temp = Average(9,3,0);
//            Console.WriteLine(temp);
//            Console.WriteLine(Average(3,3,3));
//            Console.WriteLine(Average(3, 3));
//Console.ReadLine();


//OOPs - Classes and  objects 
//        }
//    }
//}


//using System;
//using System.Diagnostics.CodeAnalysis;
//using System.Numerics;

//namespace Hello
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create object
//            Player tommy = new Player();

//            // Print default values
//            Console.WriteLine("Player Name : " + tommy.name);
//            Console.WriteLine("Player Health : " + tommy.health);

//            // Change health
//            tommy.setHealth(57);

//            Console.WriteLine("\nAfter Updating Health");
//            Console.WriteLine("Player Health : " + tommy.health);

//            Console.ReadLine();
//        }
//    }
//}


using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Player tommy = new Player();

            Console.WriteLine(tommy.name);
            Console.WriteLine(tommy.health);

            tommy.setHealth(57);

            Console.WriteLine(tommy.health);

            Console.ReadLine();
        }
    }
}












