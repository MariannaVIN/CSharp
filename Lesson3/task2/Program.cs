// на вход координаты двух точек и находит расстояние между ними в двумерном пространстве (А (3,6) В (2,1) = 5,09)
void Distance(int x, int y, int x1, int y1)
{
    int d = ((x1 - x)*(x1 - x)+(y1 - y)*(y1 - y));
    double sqr = Math.Sqrt(d);
    Console.WriteLine(sqr); 
}
Distance(3, 6, 2, 1);