// Задайте значение M и N . Напишите программу, которая выдает все натуральные числа в промежутке от M до N 


void PrintNumberRight (int M, int N)   
{
    if(M <= N)
    {
    Console.WriteLine(M);
    PrintNumberRight(M+1, N);
    }
}

PrintNumberRight(2, 15);

