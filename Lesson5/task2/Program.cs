// программа определяет, присутствует ли заданное число в массиве

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

void Show(int[] arr)
{
    Console.WriteLine("Введите число: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    int A = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if(Number == arr [i])
        {
            Console.WriteLine("Число принадлежит массиву");
            A = 1;
            break;
        }
        }
        if(A !=1)
        {
            Console.WriteLine("Число не принадлежит массиву");
        }
    }

Show(arr);