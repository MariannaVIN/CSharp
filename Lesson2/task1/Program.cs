// вывод случайного трехзначного числа и удаление второй цифры из этого числа 

int Number = new Random().Next(100,1000);
System.Console.WriteLine(Number);

int Number1 = Number / 100;

int Number2 = Number % 10;

System.Console.Write(Number1);
System.Console.WriteLine(Number2);