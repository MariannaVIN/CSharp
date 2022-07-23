// программа, которая на вход принимает число N и показывает все четные числа от 1 до N

Console.WriteLine("Введите число N=> ");

int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while(index <= N)
{
    if(index % 2 == 0)
    Console.WriteLine(index);
    index = index + 1;
}

