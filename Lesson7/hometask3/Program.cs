// задайте двумерный массив из целых чисел. Найдите среднее арифметичекое элементов в каждом столбце

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
int[,] array = CreateArray();
FillArray(array);
Printarray(array);

void AverageSum(int[,] array)
{

    for(int j = 0; j < array.GetLength(1); j++)
    {
       double sum = 0;
       double average = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        average = sum/array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое: {average}");
    }
}
AverageSum(array);