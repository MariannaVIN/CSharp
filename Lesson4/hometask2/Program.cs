// на вход  число N и выдает сумму цифр в числе

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

void sum (int N)
{
    int sum = 0;
    while (N != 0)
    {
        sum = sum + N%10;
        N = N/10;
    }
    Console.WriteLine($"Сумма цифр введенного числа = {sum}");
}

sum(N);
