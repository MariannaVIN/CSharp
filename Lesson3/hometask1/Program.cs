// на вход пятизначное число N и проверяет, является ли оно палиндромом (перевертыш)

Console.WriteLine("Введите пятизначное число:");
int N = Convert.ToInt32(Console.ReadLine());


if(N > 9999 && N < 100000)
{
    string str = N.ToString();
    if(str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
{
    Console.WriteLine("Число не является палиндромом");
}}
else
{
    Console.WriteLine("Введено не пятизначное число, повторите ввод");
}
