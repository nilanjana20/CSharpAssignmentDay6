using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignmentsDay6
{
    internal class PerfectNumber
    {
        public static void PerfectNumberProgram()
        {
          int number,sum=0,n;
            Console.Write("Enter the Number : ");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for (int i = 1; i < number;i++)
            {
                if (number % i == 0)
                {
                    sum=sum + i;
                }
            }
                if (sum == n)
                {
                    Console.WriteLine("Entered number is a perfect number");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Entered number is not a perfect number");
                    Console.ReadLine();
                }
          
        }
    }
}