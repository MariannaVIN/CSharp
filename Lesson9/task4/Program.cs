// Напишите программу, которая принимает на вход два числа A B и возводит первое в целую степень второго

int Numbers(int A, int B)   
{
    if(B >1)
    {
         A *= Numbers(A, B-1);
    }
    return A;
}
int result = Numbers(3, 3);
Console.WriteLine(result);

