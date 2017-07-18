using System;
using System.Collections.Generic;

namespace Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            Numbers[0] = 1;
            Numbers[1] = 2;
            
            int i = 2;
            while(Numbers[i] < 4000000){
                Numbers[i] = Numbers[i - 1] + Numbers[i - 2];
                i++;
                Numbers[i] = 0;
            
            }
        }
    }
}