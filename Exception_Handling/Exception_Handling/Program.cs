using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
      
        
    
        static void Main(string[] args)
        {
            try
            {
                Class1.myMethod();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please contact your System Administrator");
                Console.ReadLine();
                return;
            }





        }
    }
}
