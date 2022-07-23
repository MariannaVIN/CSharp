// принимает на вход координаты точки x y, и сказать, в какой она четверти
void CoordinatesSearch(int X, int Y)
{
    if(X == 0 || Y == 0)
    {
        Console.Write("Параметры некорректны");
    }
    else
    {
        if(X > 0 && Y > 0)
        {
            Console.Write("1"); 
        }
        if(X > 0 && Y < 0)
        {
            Console.Write("4"); 
        }
        if(X < 0 && Y > 0)
        {
            Console.Write("2"); 
        }
        if(X < 0 && Y < 0)
        {
            Console.Write("3"); 
        }
    }
}
CoordinatesSearch(2,3);
CoordinatesSearch(-2,3);
CoordinatesSearch(2,-3);
CoordinatesSearch(-2,-3);
CoordinatesSearch(0,0);