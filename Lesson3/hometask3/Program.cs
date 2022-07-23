// на вход число N и выдает таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

void Method(int N)
{
    for(int i = 1; i <= N; i++)
    {
        int s = i*i*i;
        Console.WriteLine($"{s}");
    }
}
Method(N);