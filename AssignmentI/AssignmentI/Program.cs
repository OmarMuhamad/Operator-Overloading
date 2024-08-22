using System;

namespace AssignmentI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Case for '-'
            DateTime d1 = new DateTime(2, 30, 45); // 2 hours, 30 minutes, 45 seconds
            DateTime d2 = new DateTime(1, 20, 30); // 1 hour, 20 minutes, 30 seconds
            DateTime d3 = d1 - d2;                 // 1 hour, 10 minutes, 15 seconds
            Console.WriteLine("d1 - d2 = " + d3.ToString());  

            // Test Case for '+'
            DateTime d4 = d1 + d2;                 // 3 hours, 51 minutes, 15 seconds
            Console.WriteLine("d1 + d2 = " + d4.ToString());  

            // Test Case for '+' with integer
            int additionalSeconds = 7800;          // 7800 seconds = 2 hours, 10 minutes
            DateTime d5 = d1 + additionalSeconds;  // 4 hours, 40 minutes, 45 seconds
            Console.WriteLine("d1 + 7800 seconds = " + d5.ToString()); 

            // Test Case for '++'
            DateTime d6 = new DateTime(1, 59, 59); // 1 hour, 59 minutes, 59 seconds
            d6++;                                  // 2 hours, 0 minutes, 59 seconds
            Console.WriteLine("++d6 = " + d6.ToString());     

            // Test Case for '--'
            DateTime d7 = new DateTime(1, 1, 0);   // 1 hour, 0 minutes, 0 seconds
            d7--;                                  // 0 hours, 59 minutes, 0 seconds
            Console.WriteLine("--d7 = " + d7.ToString());     

            // Test Case for '>'
            Console.WriteLine("d1 > d2 = " + (d1 < d2)); 

            // Test Case for '<'
            Console.WriteLine("d2 < d1 = " + (d2 > d1)); 

            // Test Case for '<='
            Console.WriteLine("d2 <= d1 = " + (d2 <= d1)); 

            // Test Case for '>='
            Console.WriteLine("d1 >= d2 = " + (d1 >= d2)); 

            // Test Case for '=='
            DateTime d8 = new DateTime(1, 20, 30);
            Console.WriteLine("d2 == d8 = " + (d2 == d8)); 

            // Test Case for '!='
            Console.WriteLine("d1 != d2 = " + (d1 != d2));

            if (d8) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    
    }
}