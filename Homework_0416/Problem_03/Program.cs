

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_03 // Note: actual namespace depends on the project name.
{
    /*Problem 03
    Напишите программу, которая считывает символы с клавиатуры, пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов. */

    class Program
    {
        static int countSpaces(string input =" ")
        {
            char[] chars = input.ToCharArray();
            int spaceCount = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsWhiteSpace(chars[i]))
                {
                    spaceCount++;
                }
                if (chars[i] == '.')
                {
                    break;
                }
            }
            return spaceCount;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter something: ");
            var line = Console.ReadLine();
            Console.WriteLine($"spaces in input until full stop: {countSpaces(line)}");
        }
    }
}
