// задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.

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
int[,] arr = CreateArray(3,4);
FillArray(arr);
Printarray(arr);


Console.WriteLine();

void ChangeArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (i % 2 ==1 && j % 2 ==1)
           {
            array[i,j] = array[i,j] * array[i,j];
           }
        }
    }
}


int[,] arr1 = CreateArray(3,4);
FillArray(arr1);
ChangeArray(arr);
Printarray(arr);