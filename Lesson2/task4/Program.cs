// на вход 2 числа и проверка, является ли одно (любое из них) квадратом второго

Console.WriteLine("Введите число 1:");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 == Number2 * Number2 || Number2 == Number1 * Number1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}