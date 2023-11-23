namespace KlassWork3
{
    public class Program
    {
        public static void Main(string [] arg){
            //Task2
            Random rand = new Random();
            int size = rand.Next(5, 10);
            int [] array = new int[size];
            array = InitArray (size);
            PrintArray(array);
            
        }
        public static int [] NumInArray (int num){

        }  
        public static int [] InitArray (int size) {
            int [] array = new int [size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(-10,11);
            }
            return array;
        }
        public static void PrintArray (int [] array){
            foreach (int item in array){
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
        }
    }
}