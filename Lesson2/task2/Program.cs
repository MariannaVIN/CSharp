// на вход 2 числа. Если второе число кратное певрое - то пишем кратно, если нет, то выводим остаток от деления

Console.WriteLine("Введите число 1:");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int Number2 = Convert.ToInt32(Console.ReadLine());

int result = Number1 / Number2;
if(Number1%Number2 == 0)
{
    Console.WriteLine($"Число 1 кратно числу 2");
}
else
{
    Console.WriteLine(Number1 % Number2);
}