// на вход 3 числа и проверка, может ли существовать треугольник со сторонами такой длины

Console.WriteLine("Введите число 1: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
int third = Convert.ToInt32(Console.ReadLine());

if(first < second + third && second < first + third && third < first + second)
{
    Console.WriteLine("Введенные цифры могут быть сторонами треугольника");
}
else
{
    Console.WriteLine("Введенные цифры не могут быть сторонами треугольника");
}