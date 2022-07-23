// программа, которая на вход принимает одно число N, а на выходе показывает все целые числа в промежутке от -N до N
Console.Write("Введите число => ");
string paramString = Console.ReadLine();
int paramInt1 = int.Parse(paramString);
int paramInt2 = -paramInt1;

while(paramInt2 < paramInt1)

{
    Console.Write($"{paramInt2}, ");
    paramInt2 = paramInt2 + 1;
}
Console.Write($"{paramInt1}");