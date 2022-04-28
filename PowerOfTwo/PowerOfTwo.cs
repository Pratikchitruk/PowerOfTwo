using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowerOfTwo 
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            int num, mul = 1;

            num = int.Parse(args[0]);

            if (num > 31)
            {
                Console.WriteLine("Value Of number should be less than 31");
                return;

            }
            else
            {
                Console.WriteLine(mul);
                for (int j = 1; j <= num; j++)
                {
                    mul= mul * 2;
                    Console.WriteLine(mul);

                }
            
            
            }

            
           
        }
    }
}
