using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            string holder;
            string qualified;
            int age;
            int tickets;
            bool dui;
            

            Console.WriteLine("Your age?");
            holder = Console.ReadLine();
            age = Convert.ToInt32(holder);

            Console.WriteLine("HAve you ever had a DUI? True or False");
            holder = Console.ReadLine();
            dui = Convert.ToBoolean(holder);

            Console.WriteLine("How many tickets have you gotten?");
            holder = Console.ReadLine();
            tickets = Convert.ToInt32(holder);

            if (age > 15 && dui == false && tickets < 3)
            {
                qualified = "true";
            }
            else { qualified = "false"; }

            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.ReadLine();




        }
    }
}
