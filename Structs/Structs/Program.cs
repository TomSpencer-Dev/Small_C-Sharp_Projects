using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        struct Number
        {
            public decimal Amount;
        }
        static void Main(string[] args)
        {
            Number number;

            number.Amount = 4;

            Console.WriteLine(number.Amount);
            Console.ReadLine();

        }  
        
    }
}
