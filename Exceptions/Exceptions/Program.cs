using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {

        try
        {
            List<int> numbers = new List<int>() { 55, 16, 24, 32, 9 };
            Console.WriteLine("Choose a number to divide the numbers in a list by.");
            int divisor = Convert.ToInt32(Console.ReadLine());

            foreach (int dividend in numbers)
            {
                Convert.ToInt32(dividend);
                Console.WriteLine(dividend + " divided by " + divisor + " equals: " + dividend / divisor + " Remainder: " + dividend % divisor);
            }

            Console.ReadLine();
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Program has emerged from the try/catch block and continued on with program execution.");
            Console.ReadLine();

        }
            
    }
}

