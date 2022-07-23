// задайте двумерный массив. Напишите прграмму, которая меняет местами первую и последнюю строчк массива

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
    int tempElement = array[0,0];
    int lastLine = array.GetLength(0) -1;
    for(int j = 0; j < array.GetLength(1); j++)
        {
            tempElement = array[0,j];
            array[0,j] = array[lastLine, j];
            array[lastLine, j] = tempElement;
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
Printarray(array);
