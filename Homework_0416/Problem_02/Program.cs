
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_02 // Note: actual namespace depends on the project name.
{
    /*
Problem 02
Дано целое положительные N. Найдите число, полученное при прочтении числа N справа налево и его квадрат. Например, если было введено число 345, то программа должна вывести числа 543 и 294849, а если 200, то 2 и 4.
*/
    class Program
    {
        static void reverseSquare(uint n)
        {
            string num_to_str = n.ToString();
          
  
            string[] reverseNum = new string[num_to_str.Length];
            for(int i = 0; i < num_to_str.Length; i++)
            {
                reverseNum[i] = num_to_str[i].ToString();
            }
            Array.Reverse(reverseNum);
            int reversed; 
            int.TryParse(string.Join("",reverseNum),out reversed);
            int reversedSqr = (int)Math.Pow(reversed, 2);
            Console.WriteLine($"reverse of number {n}: {reversed}; square of reversed number: {reversedSqr}");
            
        }
        
        static void Main(string[] args)
        {
            reverseSquare(345);
            reverseSquare(200);

        }
    }
}
