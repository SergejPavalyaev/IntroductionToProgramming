﻿// Task 5
namespace KlassWork2
{
    public class Program{
        public static void Main (string [] args){
            System.Console.Write("Input number => ");
            string ? numString = Console.ReadLine();
            // int numInt = Int32.Parse(numString); - перевод строки в число
            int numInt;
            while (! Int32.TryParse(numString, out numInt)){// перевод строки в число с проверкой ввода с консоли
                System.Console.WriteLine("Error, try again");
                numString = Console.ReadLine();
            }
            if (numInt > 99 && numInt < 1000) {
            int result = MathPow(numInt);
            System.Console.WriteLine(result);
            }
            
        }
        public static int MathPow(int num){
            int temp = num % 10;
            int secondDigit = temp % 10;
            int therdDigit = num % 10;
            int result = (int) Math.Pow (secondDigit, therdDigit);
            return result;
        }
}
}