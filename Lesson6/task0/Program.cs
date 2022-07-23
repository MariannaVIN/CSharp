// задайте одномерный массив из 123 случайных чисел. Найдите кол-во элементов массива, знасения которых лежат в отрезке [10, 99]

int[] FillArray()
{
    int [] array = new int [123];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}

int[] arr = FillArray();



void Count(int[] arr)
{
    int count = 0;
    for(int i =0; i < arr.Length; i++)
    {
        if(arr[i] >= 10 && arr[i] <= 99) count +=1;
    }
    Console.WriteLine($"Кол-во чисел в массиве от 10 до 99 = {count}");
}
Count(arr);