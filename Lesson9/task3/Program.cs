// Напишите программу, которая принимает на вход число и возврщает сумму его цифр

int SumNumbers (int N)   
{
    int result = 0;
    int FirstNumber = N%10;
    if(N != 0)
    {
    result += SumNumbers(N/10);
    }
    return result + FirstNumber;
}

int result = SumNumbers(0);
Console.WriteLine(result);

