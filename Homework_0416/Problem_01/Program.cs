// See https://aka.ms/new-console-template for more information


using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_01 // Note: actual namespace depends on the project name.
{
        /*
    Problem 01
    Ведите с клавиатуры номер трамвайного билета (6-значное число) и проверьте является ли данный билет счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
    */
    class Program
    {
        static void HappyNumber(int num)
        {
            string num_toStr = num.ToString();
            if (num_toStr.Length != 6)
            {
                throw new Exception("Train ticket number must be 6 digits long!");
            }
            var numArr = num_toStr.ToCharArray();
            int[] firstHalf = new int[3];
            int[] secondHalf = new int[3];
            for (int i = 0; i < numArr.Length/2; i++)
            {
                int number;
                int.TryParse(numArr[i].ToString(), out number);
                firstHalf[i] = number;
            }
            
            for(int i = numArr.Length-1, j=0; i >= numArr.Length / 2; i--, j++)
            {
                int number;
                int.TryParse(numArr[i].ToString(), out number);
                secondHalf[j] = number;
            }
            int firstSum = firstHalf.Sum();
            int secondSum = secondHalf.Sum();

            if (firstSum == secondSum)
            {
                Console.WriteLine($"the train ticket {num} is a happy number!");
            }
            else
            {
                Console.WriteLine($"the train ticket {num} is not a happy number!");
            }

        }
        static void Main(string[] args)
        {
            try
            {
                HappyNumber(123123);
                HappyNumber(238948);
                HappyNumber(304511);
                HappyNumber(143440);
                HappyNumber(546849);
                //HappyNumber(5564934);

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
