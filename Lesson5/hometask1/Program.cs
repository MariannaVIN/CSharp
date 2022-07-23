// задайте массив, заполенный случайными положительными трехзначными числами. Программа, которая покажет количество четных чисел в нем

int[] FillArray()
{
    int [] array = new int [4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
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

void CountPositive(int[] arr)
{
    int count = 0;
    for(int i =0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) count +=1;
    }
    Console.WriteLine($"Кол-во четных чисел в массиве = {count}");
}
CountPositive(arr);