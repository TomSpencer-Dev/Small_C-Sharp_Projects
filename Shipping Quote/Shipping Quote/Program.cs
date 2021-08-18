using System;


namespace Shipping_Quote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n\nPress Enter to Continue");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight using only digits:");
            string num1 = Console.ReadLine();
            int weight = Convert.ToInt32(num1);

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter the package width using only digits:");
            string num2 = Console.ReadLine();
            int width = Convert.ToInt32(num2);

            Console.WriteLine("Please enter the package height using only digits:");
            string num3 = Console.ReadLine();
            int height = Convert.ToInt32(num3);

            Console.WriteLine("Please enter the package length using only digits:");
            string num4 = Console.ReadLine();
            int length = Convert.ToInt32(num4);

            int size = width + height + length;

            if (size > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            int price = ((width * height * length) * weight) / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + price);
            Console.ReadLine();





            

        }
    }
}
