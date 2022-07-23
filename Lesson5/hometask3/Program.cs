// задайте одномерный массив, заполенный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях

int[] FillArray()
{
    int [] array = new int [6];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}

int[] arr = FillArray();

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
ShowArray(arr);

void MaxMinDiff(int[] arr)
{
    int Max = arr[0];
    int Min = arr[0];
    int res = 0;

    for(int i =0; i < arr.Length; i++)
    {
        if(arr[i] > Max) Max = arr[i];
        if(arr[i] < Min) Min = arr[i];
    }
    res = Max - Min;
    Console.WriteLine($"Разница между макс и мин числами равна {res}");
}
MaxMinDiff(arr);