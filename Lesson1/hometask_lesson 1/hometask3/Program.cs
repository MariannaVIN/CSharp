// программа, которая на вход принимает число и выдает, является ли число четным

Console.WriteLine("Введите число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

if(paramInt % 2  == 0)
{
    Console.WriteLine("четное число");
}
else
{
    Console.WriteLine("нечетное число");
}



