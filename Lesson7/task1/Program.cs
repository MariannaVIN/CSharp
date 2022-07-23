// задайте двумерный массив m * n, каждый элемент массива находится по формуле Аgit  = i+j. Вывести массив на экран.

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
           array[i,j] = i+j;
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
int[,] arr = CreateArray(3,4);
FillArray(arr);
Printarray(arr);