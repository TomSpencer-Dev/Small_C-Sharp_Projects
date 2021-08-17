using System;


namespace Math_Operation_Assignment
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Math Operation Assignment \n Academy of Learning");
            Console.WriteLine("\nEnter a whole number using digits:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int product = num1 * 50;
            Console.WriteLine("Fifty times " + num1 + " = " + product.ToString());
            Console.WriteLine("\n Press Enter");
            Console.ReadLine();


            Console.WriteLine("\nEnter a whole number using digits:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num2 + 25;
            Console.WriteLine("Twenty Five plus " + num2 + " = " + sum.ToString());
            Console.WriteLine("\n Press Enter");
            Console.ReadLine();

            Console.WriteLine("\nEnter a number using digits:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double quotient = num3 / 12.5;
            Console.WriteLine(+num3 + " divided by 12.5 =" + quotient.ToString());
            Console.WriteLine("\n Press Enter");
            Console.ReadLine();

            Console.WriteLine("\nEnter a whole number using digits:");
            int num4 = Convert.ToInt32(Console.ReadLine());

            bool trueOrFalse = num4 > 50;
            Console.WriteLine(+num4 + " is greater than 50:");
            Console.WriteLine(trueOrFalse.ToString());
            Console.WriteLine("\n Press Enter");
            Console.ReadLine();

            Console.WriteLine("\nEnter a whole number using digits:");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int remainder = num5 % 7;
            Console.WriteLine(+num5 + " divided by seven has a remainder of: " + remainder);
            Console.WriteLine("\n Thank You, Good Bye.");
            Console.ReadLine();

            

        }
    }
}
