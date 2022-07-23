// Задайте значение M и N . Напишите программу, которая выдает сумму натуральных чисел в промежутке от M до N 

int SumAllNumbers(int M, int N)
{
    if (M < N) return M + SumAllNumbers(M + 1, N);
    if (M > N) return N + SumAllNumbers(M, N + 1);
    else return M;
}


Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumAllNumbers(M, N));


