// программа вычисления куба x=f(a)
Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int paramInt = int.Parse(paramString);

Console.WriteLine("Вы ввели число: " + paramInt);
int result = paramInt * paramInt * paramInt;
Console.WriteLine($"Куб числа {paramInt} равен {result}");

