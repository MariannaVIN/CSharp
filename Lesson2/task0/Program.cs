// рандомное число от 10 до 99, и выбрать максимальную цифр из числа
int Number = new Random().Next(10,100);
System.Console.WriteLine(Number);
int NumberA = Number%10;
int NumberB = Number/10;

if(NumberA > NumberB)
{
    Console.WriteLine(NumberA);
}
else
{
    Console.WriteLine(NumberB);
}