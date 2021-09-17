using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Date and Time is: ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now + "\n\nEnter a number");
            int X = Convert.ToInt32(Console.ReadLine());

            DateTime newTime = now.AddHours(X);
            Console.WriteLine("It will be " + newTime + " " + X + " hours from now.");
            Console.ReadLine();



            
        }
    }
}
