using System;

namespace CG_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            //string myLastName;
            //Console.Write("Type your last name: ");
            //myLastName = Console.ReadLine();

            Console.WriteLine("Type your last name: ");
            string myLastName = Console.ReadLine();




            Console.WriteLine("Hello " + fullName(myFirstName, myLastName));
            Console.ReadLine();





        }
        private static string fullName(string myFirstName, string myLastName)

        {
            return (myFirstName + " " + myLastName);
        }


    }
}
