// на вход число N и выдает произведение чисел от 1 до N

int Factorial(int N)
{
    int result = 1;
    for(int i = 1; i <= N; i++)
    {
        result = result*i;
    }
return result;
}

Console.WriteLine(Factorial(0));

// на вход число А и выдает сумму чисел от 1 до А

