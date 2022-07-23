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

void SumNegatives(int[] arr)
{
    int sum = 0;
    for(int i =0; i < arr.Length; i++)
    {
        if(arr[i]%2 != 0) sum = sum + arr[i];
    }
    Console.WriteLine($"Сумма нечетных чисел = {sum}");
}
SumNegatives(arr);
