// Задайте значение N. Напишите программу, которая выдает все натуральные числа в промежутке от 1 до N

void PrintNumber (int N)  // 1 способ 
{
    if(N!= 0)
    {
    Console.WriteLine(N);
    PrintNumber(N-1);
    }
}

PrintNumber(10);

void PrintNumberRight (int start, int N)   // 2 способ
{
    if(start != N+1)
    {
    Console.WriteLine(start);
    PrintNumberRight(start+1, N);
    }
}

PrintNumberRight(1, 20);