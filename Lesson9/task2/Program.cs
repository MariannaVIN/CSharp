// Задайте значение M и N . Напишите программу, которая выдает все натуральные числа в промежутке от M до N c неким шагом


void PrintNumberRight (int M, int N, int step)   
{
    if(M <= N)
    {
    Console.WriteLine(M);
    PrintNumberRight(M+step, N, step);
    }
}

PrintNumberRight(2, 15, 2);

