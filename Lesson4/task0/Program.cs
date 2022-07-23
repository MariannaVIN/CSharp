// на вход число А и выдает сумму чисел от 1 до А

int Sum (int A)
{
    int result = 0;
    for(int i = 0; i <= A; i++)
    {
        result = result + i;
    }
return result;
}
int S = Sum(5);
Console.WriteLine(S);