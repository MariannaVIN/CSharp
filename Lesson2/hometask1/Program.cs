// принимает на вход трехзначное число и выдает вторую его цифру (546 -> 4)

Console.WriteLine("Введите трехзначное число:");
int Number = Convert.ToInt32(Console.ReadLine());


int Number2 = Number / 10;

int Number2a = Number2 % 10;

System.Console.Write(Number2a);

