// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");

int Number = Convert.ToInt32(Console.ReadLine());


if(Number < 100)
{
    Console.WriteLine("Такого числа нет");
}
else
{
    string str = Number.ToString();
    Console.WriteLine(str[2]);
}    