// на вход 1 число и проверка, кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число:");
int Number = Convert.ToInt32(Console.ReadLine());


if(Number%7 == 0 && Number%23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}