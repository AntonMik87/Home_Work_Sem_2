// Найти расстояние между точками в пространстве 2D/3D

double Distance2D(int xa, int ya, int xb, int yb)
{
    return Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2));
}
Console.WriteLine(Distance2D(0, 1, 2, -2));

double Distance3D(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
}
Console.WriteLine(Distance3D(-1, 2, 3, 6, 2, -2));