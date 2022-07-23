// программа - на вход 2 числа и выдает, какое большее, а какое меньшее

Console.Write("Введите число 1=> ");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1);

Console.Write("Введите число 2=> ");
string paramString2 = Console.ReadLine();
int paramInt2 = int.Parse(paramString2);
Console.WriteLine("Вы ввели число 1: " + paramInt1);
Console.WriteLine("Вы ввели число 2: " + paramInt2);

if(paramInt1 < paramInt2)
{
    Console.WriteLine("число 1 меньше числа 2");
}
else
{
    Console.WriteLine("число 1 больше числа 2");
}
