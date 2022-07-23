// на вход координаты двух точек и находит расстояние между ними в трехмерном пространстве (А (3,6, 8) В (2,1, -7) = 15,84)
void Distance(int x, int y, int z, int x1, int y1, int z1)
{
    int d = ((x1 - x)*(x1 - x)+(y1 - y)*(y1 - y) + (z1 - z)* (z1 - z));
    double sqr = Math.Sqrt(d);
    Console.WriteLine(sqr); 
}
Distance(3, 6, 8, 2, 1, -7);
