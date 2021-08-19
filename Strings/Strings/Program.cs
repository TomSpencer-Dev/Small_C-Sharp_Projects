using System;
using System.Text;


namespace Strings
{
    class Program
    {
        static void Main()
        {
            string one = "hello,";
            string two = " how are";
            string three = " you?";

            Console.WriteLine(one + two + three);
            Console.ReadLine();

            one = one.ToUpper();

            Console.WriteLine(one);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("Hello, how are you?");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
