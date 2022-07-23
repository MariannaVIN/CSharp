// выведите первые N чисел Фибоначи. Первые два числа: 0 и 1

int[] ArrayFibonacci = CreateFibArray();
PrintArray(ArrayFibonacci);

int[] CreateFibArray()
{
    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[N];
    array[0] = 0;
    array [1] = 1;
     for (int i = 2; i < N; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

