using System;


namespace Loop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess how many pets I have?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool pets = number == 2;

            while (!pets) ;

            switch (number)
            {
                case 1:
                    Console.WriteLine("You guessed 1. Try again.");
                    Console.WriteLine("Guess how many pets I have?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("You guessed 2. You are right!");
                    pets = true;
                    break;
                    
                case 3:
                    Console.WriteLine("You guessed 3. Try again.");
                    Console.WriteLine("Guess how many pets I have?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;

                case 4:
                    Console.WriteLine("You guessed 4. Try again.");
                    Console.WriteLine("Guess how many pets I have?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;

                case 0:
                    Console.WriteLine("You guessed 0. Try again.");
                    Console.WriteLine("Guess how many pets I have?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("You are wrong. Try again.");
                    Console.WriteLine("Guess how many pets I have?");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }


        }
    }
}
