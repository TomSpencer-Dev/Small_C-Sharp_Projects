using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class Program
    {
        
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        internal static Program.DaysOfTheWeek Parse(Type type, string day1)
        {
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the day of the week, being sure to capitalize the first letter of the word.");
                string day1 = Console.ReadLine();

                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day1);
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finisehd.");
                Console.ReadLine();
            }

        }
    }
}
