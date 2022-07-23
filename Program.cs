// Напишите программу, которая на вход принимает число и выдает его квадрат
Console.Write("Введите число => ");                         // вывод на экран приглашения
string paramString = Console.ReadLine();                    // чтение строки с клавиатуры
int paramInt = int.Parse(paramString);                      // преобразование строки в число
Console.WriteLine("Вы ввели число: " + paramInt);           // вывод этого числа
int result = paramInt * paramInt;                           // вычисление квадрата
Console.WriteLine($"Результат (квадрат числа {paramInt}) = {result}");  // вывод результата, $ - для возможности ввода параметров (симв подстановки)