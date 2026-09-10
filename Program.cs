using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Console.ReadLine();

            int age = 21;
            double name = 5.444;
            float surname = 09;
            char realname = 'k';
            string namefull = "kalyani";
            //const int myname = 10;
            //Console.ReadLine();

            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(realname);
            Console.WriteLine(namefull);




            Console.WriteLine("       STUDENT IMFORMATION");
            int AGE = 21;
            string names = "kalyani";
            float percentage = 94 ;
            char grad = 'A';


            Console.WriteLine(" Age: "  +AGE);
            Console.WriteLine(" name: " + names);
            Console.WriteLine(" perc: " + percentage);
            Console.WriteLine(" grad: " + grad);

            string k = "kalyani kadu";
            int agge = 21;
            Console.WriteLine($" my name is: {k}");

            Console.WriteLine($"my age is:{agge}");

            string j ="pink dress";
            Console.WriteLine($"my fav color is red but i want {j}");


            Console.ReadLine();



            Console.Write("enter the name");
            string namee = Console.ReadLine();
            Console.WriteLine($"HELLO  HOW ARE YOU{ namee}");


            Console.Write("enter the year ");

            int year =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine($"YEAR{2026}");
            Console.ReadLine();


        }
    }
}
