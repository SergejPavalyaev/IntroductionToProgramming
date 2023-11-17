System.Console.WriteLine("Input Numbers1");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input Numbers2");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == Math.Pow(num2,2)) {
    Console.WriteLine("True");
}
else {
    Console.WriteLine("False");
}