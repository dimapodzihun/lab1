using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task №1
            String name = "Дмитро";
            String surname = "Подзігун";
            int age = 17;
            Console.WriteLine($"Мене звати {name} {surname}, мені {age} років");



            //task №2
            int a = 3;
            int b = 5;
            double result;
            result = (Math.Pow(a-b, 3) - (Math.Pow(a, 3) - 3 * Math.Pow(a, 2) * b) )
                / (Math.Pow(b, 3) - 3 * a * Math.Pow(b, 2));
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine();



            //task №3

            Console.WriteLine("Введіть тризначне число:");

           
            double number = Convert.ToDouble(Console.ReadLine());

            
            double firstDigit = number % 10;
            double secondDigit = (number % 100 - firstDigit) / 10;
            double thirdDigit = (number - secondDigit * 10 - firstDigit) / 100; 

            
            string reversedNumber = firstDigit.ToString() + secondDigit.ToString() + thirdDigit.ToString();

            Console.WriteLine("Перевернуте число: " + reversedNumber);
            Console.ReadLine();







        }
    }
}
