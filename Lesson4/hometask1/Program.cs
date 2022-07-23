// напишите цикл, который принимает на вход два числа А и В и возводит число А в натуральную степень В

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

if(B < 0) Console.WriteLine("Введенное число В должно быть положительным");
else
{
    Console.WriteLine($"Результат = {Multi(A, B)}");
}
int Multi(int Base, int Pow)
{
    int res = 1;
    for(int i = 1; i <=Pow ; i++)
    {
        res *=Base;
    }
    return res;
}
