// программа замены элементов массива: положительные на отрицательные и наоборот

int[] FillArray()
{
    int [] array = new int [4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99,100);
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

void Conversion(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i]*(-1);
    }
}
Conversion(arr);
ShowArray(arr);
