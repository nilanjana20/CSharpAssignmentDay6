using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignmentsDay6
{
    internal class FibonacciSeries
    {
        public static void FibonacciSeriesProgram()
        {
           int n1=0,n2=1,n3,i,number;    
         Console.Write("Enter the number of elements: ");    
         number = Convert.ToInt32(Console.ReadLine());
          //printing 0 and 1   
         Console.Write(n1+" "+n2+" ");  
          //loop starts from 2 because 0 and 1 are already printed    
         for(i=2;i<number;++i) 
         {    
          n3=n1+n2;    
          Console.Write(n3+" ");    
          n1=n2;    
          n2=n3;    
         }    
        }
    }
}