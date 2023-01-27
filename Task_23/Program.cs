Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < N +1; i += 1)
{
        Console.WriteLine(Math.Pow(i, 3));
}
