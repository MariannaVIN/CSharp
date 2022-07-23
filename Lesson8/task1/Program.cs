// задайте двумерный массив. Напишите прграмму, которая заменяет местами строки и столбцы. Если это невозможно, выдать ошибку

int[,] CreateArray ()  // запятая внутри массива означает, что он двумерный
{
    Console.WriteLine("Введите количеств строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количеств столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m,n];
    return array;
}

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void ChangeArray(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Замена невозможна ");
    }
    else
    {
        int[,] arr = new int[array.GetLength(0), array.GetLength(1)];
        for(int i = 0; i < array.GetLength(1); i++)
        {
             for(int j = 0; j < array.GetLength(1); j++)
             {
                arr[i,j] = array[j,i];
             }
        }
        Printarray(arr);
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
        Console.WriteLine();
    }
     Console.WriteLine();
}
int[,] array = CreateArray();

FillArray(array);
Printarray(array);
ChangeArray(array);
