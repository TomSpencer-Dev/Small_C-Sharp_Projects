﻿using System;


namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine(); 

            //int product = 10 * 5;
            //Console.WriteLine("Ten times Five = " + product.ToString());
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 70;

            //bool isWarm = currentTemperature <= roomTemperature;
            bool isWarm = currentTemperature != roomTemperature;
            
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
