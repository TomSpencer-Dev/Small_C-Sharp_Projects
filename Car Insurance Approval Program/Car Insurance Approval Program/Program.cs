using System;


namespace Car_Insurance_Approval_Program
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Car Insurance Approval \n\nPress Enter to Begin");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            string num1 = Console.ReadLine();
            int age = Convert.ToInt32(num1);

            Console.WriteLine("Have you ever had a DUI?\n\ntrue or false?");
            string textBoxAnswer = Console.ReadLine();
            bool dui = Convert.ToBoolean(textBoxAnswer);
           
                

            


            Console.WriteLine("How many speeding tickets do you have?");
            string num3 = Console.ReadLine();
            int tickets = Convert.ToInt32(num3);

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui == false && tickets <= 3);
            Console.ReadLine();
            
            
        }
    }
}
