using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace C_sharp_strings
//{
//    class Program

//    {
//        static void Main(string[] args)
//        {
//            string val = "Whatewert we want";
//            string val2 = "whatewer";
//            Console.WriteLine(val);

//            Console.WriteLine(val.ToUpper());

//            Console.WriteLine(val);

//            Console.WriteLine(val.ToLower());

//            Console.WriteLine(val.ToLower().Contains(val2));

//            Console.WriteLine(val.LastIndexOf('t'));

//            Console.WriteLine(val.Length);

//            Console.WriteLine(val.Replace('w', 'j'));

//            Console.WriteLine(val.Replace("we", "j"));

//            Console.WriteLine(val.Remove(3));
//            Console.WriteLine(val.Remove(0, 3));
//            Console.WriteLine(val.Remove(2, val.Length - 4));

//            Console.WriteLine(val.Substring(3));
//            Console.WriteLine(val.Substring(3, 5));
//            Console.WriteLine(val.Substring(val.Length - 3));


//            Console.WriteLine(val.StartsWith("wha"));
//            Console.WriteLine(val.EndsWith("we"));

//            string url = "    www.goo gle.com/ssasd/as/dasd/asd/asd             ";
//            string[] part = url.Split(' ');
//            Console.WriteLine(part[0]);

//            Console.WriteLine(url);
//            Console.WriteLine(url.Trim());




//        }

//    }
//}


//namespace C_sharp_files
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            if(!File.Exists("settings/mytextfile.txt"))
//            {
//                File.Create("settings/mytextfile.txt");

//            }
//            //Console.WriteLine(File.Exists("settings/mytextfile.txt"));
//            //Console.WriteLine(File.Exists("sssettingssss/mytextfile.txt"));


//            //Directory.CreateDirectory("settings");
//            //(@"C:\Users\OM SRIVASTAV\source\repos\23 jul\bin\debug\file.txt");

//        }
//    }
//}

//namespace C_sharp_files
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            File.Create("settings/mytextfile.txt");
//            //Directory.CreateDirectory("settings");'
//            Console.WriteLine(File.Exists("settings/mytextfile.txt"));

//            Console.WriteLine(File.Exists("settingsss/mytextfile.txt"));


//        }
//    }
//}


//namespace C_sharp_files
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            if (!File.Exists("settings/mytextfile.txt"))
//            {
//                //Create new file 
//                File.Create("settings/mytextfile.txt");

//            }
//            else
//            {
//                //Read it
//                string[] lines = File.ReadAllLines("settings/mytextfile.txt");
//                for (int i = 0; i < lines.Length; i++)
//                {
//                    Console.WriteLine(lines[i]);

//                }
//                //OPEN , READ 
//                string fileContent = File.ReadAllText("settings/mytextfile.txt");
//                Console.WriteLine(fileContent);

//                //byte[] temp = File.ReadAllBytes("settings/mytextfile.txt");
//                //for (int i = 0;i < temp.Length;i++)
//                //{
//                //    Console.WriteLine(temp[i]);
//                //}
//                //REPLACE 
//                string replaced = fileContent.Replace('a', 'b');

//                //Save file 
//                File.WriteAllText("settings/mytextfile2.txt", replaced);
//                string[] newLines = {"\n", "wow", "this", "is", "cool" };
//                File.WriteAllLines("settings/mytextfile3.txt", newLines);

//                //Append file
//                File.AppendAllText("settings/mytextfile2.txt", replaced);
//                File.AppendAllLines("settings/mytextfile2.txt"),newLines);




//            }
//        }
//    }
//}

namespace C_sharp_files
{
        class Program
        {
            static void Main(string[] args)
            {
                if (!File.Exists("settings/mytextfile.txt"))...
                else...

                FileInfo info = new FileInfo("settings/mytextfile.txt");

                Console.WriteLine(info.Directory);
                Console.WriteLine(info.Extension);
                Console.WriteLine(info.IsReadOnly);
                Console.WriteLine(info.LastAccessTime);
                Console.WriteLine(info.LastWriteTime);
                Console.WriteLine(info.Length);
                Console.WriteLine(info.Name);
                

            }


        }
}
                


