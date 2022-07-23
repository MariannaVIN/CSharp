// выдача дня недели по заданном параметру (пн =1, ср =3 и тд)
Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

Console.WriteLine("Вы ввели день недели: " + paramInt);

if(paramInt == 1)
{
    Console.WriteLine("Понедельник");
}
if(paramInt ==2)
{
    Console.WriteLine("Вторник");
}
if(paramInt == 3)
{
    Console.WriteLine("Среда");
}
if(paramInt == 4)
{
    Console.WriteLine("Четверг");
}
if(paramInt == 5)
{
    Console.WriteLine("Пятница");
}
if(paramInt == 6)
{
    Console.WriteLine("Суббота");
}
if(paramInt == 7)
{
    Console.WriteLine("Воскресенье");
}
if(paramInt > 7)
{
    Console.WriteLine("Такого дня нет))");
}