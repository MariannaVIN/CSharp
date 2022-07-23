// на вход  число N и выдает, сколько цифр в числе

void quantity (string Number)
{
    int count = Number.Length;
    Console.WriteLine($"Кол-во цифр = {count}");
}

Console.Write("Введите число:");
string Number = Console.ReadLine();
quantity (Number);
