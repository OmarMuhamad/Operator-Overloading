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
            Console.WriteLine("d1 = " + d1);
            Console.WriteLine("d2 = " + d2);
            Console.WriteLine("d1 - d2 = " + d3.ToString());

            // Test Case for '+'
            DateTime d4 = d1 + d2;                 // 3 hours, 51 minutes, 15 seconds
            Console.WriteLine("d1 + d2 = " + d4.ToString());

            Console.WriteLine();

            // Test Case for '+' with integer
            int additionalSeconds = 7800;          // 7800 seconds = 2 hours, 10 minutes
            DateTime d5 = d1 + additionalSeconds;  // 4 hours, 40 minutes, 45 seconds
            Console.WriteLine("d1 + 7800 seconds = " + d5.ToString());
            DateTime d6 = additionalSeconds + d1;  // 4 hours, 40 minutes, 45 seconds
            Console.WriteLine("7800 + d1 seconds = " + d6.ToString());

            Console.WriteLine();

            // Test Case for '++'
            DateTime d7 = new DateTime(1, 59, 59); // 1 hour, 59 minutes, 59 seconds
            Console.WriteLine("d7 = " + d7);
            d7++;
            Console.WriteLine("d7++ = " + (d7).ToString());      // 2 hours, 0 minutes, 59 seconds
            Console.WriteLine("++d7 = " + (++d7).ToString());    // 2 hours, 1 minutes, 0 seconds

            Console.WriteLine();

            // Test Case for '--'
            DateTime d8 = new DateTime(1, 1, 0);   // 1 hour, 1 minutes, 0 seconds
            Console.WriteLine("d8 = " + d8);
            d8--;
            Console.WriteLine("d8-- = " + d8.ToString()); // 1 hours, 0 minutes, 0 seconds
            Console.WriteLine("--d8 = " + (--d8).ToString()); // 0 hours, 59 minutes, 0 seconds

            Console.WriteLine();

            Console.WriteLine("d1 = " + d1);
            Console.WriteLine("d2 = " + d2);
            // Test Case for '>'
            Console.WriteLine("d1 > d2 = " + (d1 > d2)); 

            // Test Case for '<'
            Console.WriteLine("d1 < d2 = " + (d1 < d2)); 

            // Test Case for '<='
            Console.WriteLine("d2 <= d1 = " + (d2 <= d1)); 

            // Test Case for '>='
            Console.WriteLine("d2 >= d1 = " + (d2 >= d1)); 

            // Test Case for '=='
            DateTime d9 = new DateTime(1, 20, 30);
            Console.WriteLine("d2 == d9 = " + (d2 == d9)); 

            // Test Case for '!='
            Console.WriteLine("d1 != d2 = " + (d1 != d2));

            if (d9) Console.WriteLine("d9 is not null");
            else Console.WriteLine("d9 is null");
        }
    
    }
}