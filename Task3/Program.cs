namespace Task3
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
            int result;
            if (numInt > 99) {
                while (numInt > 999){
                numInt = numInt / 10;
                }
                result = numInt % 10;
                System.Console.WriteLine($"Result => {result}");
            }
            else System.Console.WriteLine("Третьей цифры нет");
        }
}
}