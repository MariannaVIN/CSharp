// задайте двумерный массив. Найдите сумму элементов находящихся на главной диагонали (с индексами (0,0), (1,1) и тд)

int[,] CreateArray (int n, int m)  // запятая внутри массива означает, что он двумерный
{
    return new int [n, m];
}

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void Printarray(int [,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        System.Console.WriteLine();
    }
}
int[,] arr = CreateArray(5,5);
FillArray(arr);
Printarray(arr);


Console.WriteLine();

void SumMainArray(int [,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (i == j)
           {
            sum += array[i,j];
           }
        }
    }
    Console.WriteLine($"сумма элементов на главной диагонали равна {sum}");
}


int[,] arr1 = CreateArray(5,5);
FillArray(arr1);
SumMainArray(arr);

