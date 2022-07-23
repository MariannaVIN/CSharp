// программа, которая на вход принимает позиции элемента в двумерном массиве и возвращает значение этого элемента 
// или указание, что такого элемента нет

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

void ShowElement(int[,] array)
{
    Console.WriteLine("Введите номер строки: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if(n> array.GetLength(0) || m > array.GetLength(1))
    {
        Console.WriteLine("Число нахдится вне массива ");
    }
    else
    {
        Console.WriteLine($"Искомое число: {array[(n-1), (m-1)]}");
    }
}
ShowElement(array);