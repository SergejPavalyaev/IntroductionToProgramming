namespace KlassWork4_Task1
{
    public class Program
    {
        public static void Main (string [] args){
            System.Console.WriteLine("Input size array => ");
            int size = InputNumber();
            System.Console.WriteLine("Input array => ");
            int [] array = new int [size];
            for (int i = 0; i < size; i++)
            {
                array [i] = InputNumber();
            }
            int divide = 7;
            int end = 1;
            int count = DivideNumberEndNumber(array, divide, end);
            System.Console.WriteLine($"Result = {count}");

        }
        
        public static int InputNumber (){
            string ? numString = Console.ReadLine();
            int numInt;
            while (! Int32.TryParse(numString, out numInt)){// перевод строки в число с проверкой ввода с консоли
                System.Console.WriteLine("Error, try again");
                numString = Console.ReadLine();
            }
            return numInt;
        }
        public static int DivideNumberEndNumber (int [] array, int divide, int end){
            int count = 0;
            foreach (int item in array)
            {
                if (item % 10 == end & item % 7 == 0) count++;
            }
            return count;
        }
    }
}