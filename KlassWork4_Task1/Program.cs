namespace KlassWork4_Task1
{
    public class Program
    {
        public static void Main (string [] args){
            System.Console.WriteLine("Input size array => ");
            int size = InputNumber();
            // System.Console.WriteLine("Input array => ");
            int min = 0;
            int max = 9;
            int [] array = InitArrayRandom(size, min, max);
            PrintArray(array);
            // int divide = 7;
            // int end = 1;
            // int count = DivideNumberEndNumber(array, divide, end);
            // System.Console.WriteLine($"Result = {count}");
            int numbers = NumberFromArray(array, size);
            System.Console.WriteLine($"Number from array = > {numbers}");

        }
        
        public static int InputNumber (){
            // string ? numString = Console.ReadLine();
            // int numInt;
            // while (! Int32.TryParse(numString, out numInt)){    // перевод строки в число с проверкой ввода с консоли
            //     System.Console.WriteLine("Error, try again");
            //     numString = Console.ReadLine();
            // }
            int numInt = 0;
            bool flag = false;
            bool flag2 = false;
            while (!flag2){
                while (!flag) // метод try-catch. Если ошибка - выведи сообщение. Возможно добавить исключения. Лучше комбинировать с while.
                {
                    try 
                    {
                        numInt = Convert.ToInt32(System.Console.ReadLine());
                        flag = true;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Error, try again");
                        flag = false;
                    }
                }
                if (numInt >= 0 & numInt <= 8) {//условия на проверку ввода
                    flag2 = true;
                }
                else {
                    System.Console.WriteLine("Error, try again");
                    flag = false;//отправляет повторно запускать цикл try-catch
                }
            }
            return numInt;
        }
        public static int [] InitArrayRandom (int size, int min, int max){
            Random rand = new Random ();
            int [] array = new int [size];
            if (min > max) {
                int temp = max;
                max = min;
                min = temp;
            }
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(min, max + 1);
            }
            return array;
        }
        public static int DivideNumberEndNumber (int [] array, int divide, int end){
            int count = 0;
            foreach (int item in array)
            {
                if (item % 10 == end & item % 7 == 0) count++;
            }
            return count;
        }
        public static void PrintArray (int [] array){
            foreach (int item in array)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
        }
        public static int NumberFromArray (int [] array, int size){
            int number = 0;
            // array[0] = 0;
            // array[1] = 0;
            for (int i = 0; i < size; i++)
            {
                number += array[i] * (int)Math.Pow(10, size - 1 - i);           
            }
            return number;
        }
    }
}