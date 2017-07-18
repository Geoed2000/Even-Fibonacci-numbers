using System;
using System.Collections.Generic;

namespace Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Limit = 4000000;

            List<int> Numbers = new List<int>();
            Numbers.Add(1);
            Numbers.Add(2);

            int Count = 1;
            while(Numbers[Count] < Limit){
                Count++;
                Numbers.Add(Numbers[Count - 1] + Numbers[Count - 2]);
                                    
            }
            Numbers.RemoveAt(Count);

            int Sum = 0; 
            foreach (int i in Numbers)
            {
                if (i % 2 == 0)
                {
                    Sum += i;
                }
            }
            Console.WriteLine("The sum of all the Even fibonacci numbers under 4,000,000 is " + Sum);
            Console.ReadLine();
        }
    }
}