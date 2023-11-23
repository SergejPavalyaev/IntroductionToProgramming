namespace KlassWork3
{
    public class Program
    {
        public static void Main(string [] arg){
            // int [] array = {-4, -5, 4, 5, 2};
            // foreach (int item in array){
            //     System.Console.Write(item + " ");
            // }
            int size = 5;
            int [] array = new int[size];
            Random rand = new Random();
            int num = 3;
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(-10,11);
            }
            foreach (int item in array){
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Search num = {num}");
            System.Console.Write(IsNumInArray(array,num));
        }
        public static bool IsNumInArray(int [] array, int num){
            foreach (int item in array)
            {
                if (item == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}