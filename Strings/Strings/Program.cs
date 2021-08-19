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

            sb.Append("The dog went to the park.");
            sb.Append(" The owner, Greg, didn't know where his dog was.");
            sb.Append(" So he whistled.");
            sb.Append(" His dog heard the whistles and ran home.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
