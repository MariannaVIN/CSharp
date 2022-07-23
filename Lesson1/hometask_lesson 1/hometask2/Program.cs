// выдача максимума из трех введенных чисел

Console.WriteLine("Введите первое число: ");
double A = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double B = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double C = Convert.ToDouble (Console.ReadLine());

double max = A;

if (B > max) max = B;
if (C > max) max = C;

Console.Write ("Большее число: ");
Console.WriteLine (max);

