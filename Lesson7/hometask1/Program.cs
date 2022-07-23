// задайте двумерный массив m на n, заполенный случайными вещественными числами

double[,] CreateArray ()  // запятая внутри массива означает, что он двумерный
{
    Console.WriteLine("Введите количеств строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количеств столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m,n];
    return array;
}

void FillArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble();
        }
    }
}

void Printarray(double [,] array)
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
double[,] array = CreateArray();
FillArray(array);
Printarray(array);

