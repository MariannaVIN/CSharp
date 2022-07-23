// по заданному параметру четверти показывает ди апазон возможных координат точек в этой четверти (x и y)
void CoordinateDemo(int part)
{
    if(part < 1 || part > 4)
    {
        Console.WriteLine("Заданы неверные параметры четверти");
    }
    else
    {
        if(part == 1)
        {
            Console.WriteLine("x > 0 и y > 0"); 
        }
       if(part == 2)
        {
            Console.WriteLine("x < 0 и y > 0"); 
        }
         if(part ==3)
        {
            Console.WriteLine("x < 0 и y < 0"); 
        }
         if(part ==4)
        {
            Console.WriteLine("x > 0 и y < 0"); 
        }
    }
}
CoordinateDemo(1);
CoordinateDemo(2);
CoordinateDemo(3);
CoordinateDemo(4);
CoordinateDemo(5);
CoordinateDemo(-6);
