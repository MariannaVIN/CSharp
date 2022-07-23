// на вход число N и выдает таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

void Method(int N)
{
    for(int i = 0; i <= N; i++)
    {
        int s = i*i;
        Console.WriteLine($"{s}");
    }
}
Method(N);