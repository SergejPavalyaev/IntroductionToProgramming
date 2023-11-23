namespace KlassWork3
{
    public class Program
    {
        public static void Main(string [] arg){
            int size = 5;
            int [] array = new int[size];
            Random rand = new Random();
            int num = rand.Next(-10,11);
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(-10,11);
            }
            foreach (int item in array){
                System.Console.Write(item + " ");
            }
            bool flag = IsNumInArray(array,num);
            string result = flag ? "yes" : "no"; //тернарный оператор(выбор из двух значений при выполнении условия)
            System.Console.WriteLine();
            System.Console.WriteLine($"Search num = {num}");
            System.Console.Write(result);
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