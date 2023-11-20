// Task 5
namespace KlassWork2
{
    public class Program{
        public static void Main (string [] args){
            System.Console.Write("Input number => ");
            string ? numString = Console.ReadLine();
            // int numInt = Int32.Parse(numString); - перевод строки в число
            int numInt;
            while(! Int32.TryParse(numString, out numInt)){// перевод строки в число с проверкой ввода с консоли
                System.Console.WriteLine("Error, try again");
                numString = Console.ReadLine();
            }
            int result = DeletDigit(numInt);
            System.Console.WriteLine(result);
        }
        public static int DeletDigit(int num){
            int result;
            int firstDigit = num / 100;
            int secondDigit = num % 10;
            result = firstDigit * 10 + secondDigit;
            return result;
        }
}
}