// пользователь вводит с клавиатуры М чисел. Сколько чисел больше 0 он ввел

int[] NewArray = CreateFillArray();

int[] CreateFillArray()
{
    Console.WriteLine("Введите размер массива: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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
PrintArray(NewArray);


void PositiveCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    Console.WriteLine($"Кол-во положительных чисел = {count}");
}
PositiveCounter(NewArray);