// ввод двух чисел и проверка, является ли первое квадратом второго

Console.Write("Введите первое число => ");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1);
Console.Write("Введите второе число => ");
string paramString2 = Console.ReadLine();
int paramInt2 = int.Parse(paramString2);

Console.WriteLine("Вы ввели число 1: " + paramInt1);
Console.WriteLine("Вы ввели число 2: " + paramInt2);
if(paramInt1 ==paramInt2 * paramInt2)
{
    Console.WriteLine("Да, число 1 является квадратом числа 2");
}
else
{
    Console.WriteLine("Нет, число 1 не является квадратом числа 2");
}