using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class Class1
    {
        public static void myMethod()
        {
            Console.WriteLine("Please enter your age:");
            int currentDate = DateTime.Now.Year;
            int age = Convert.ToInt32(Console.ReadLine());
            int DOB = currentDate - age;
            if (age <= 0)
            {
                Console.WriteLine("Please enter a number greater than 0");
                Class1.myMethod();
                Console.ReadLine();
                
                

            }

            else
            {
                Console.WriteLine("You were born in " + DOB);
                Console.ReadLine();
            }
        }
}
}
