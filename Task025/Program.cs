Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int B = int.Parse(Console.ReadLine());


for (int i = 0; i <= B; i++)
{
   Console.WriteLine($"{A}^{i} = {Math.Pow(A,i)}");
}
