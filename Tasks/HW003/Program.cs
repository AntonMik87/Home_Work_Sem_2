// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти");
int i = int.Parse(Console.ReadLine() ?? "0");



if (i <= 0)
{
    Console.WriteLine("Введите номер от 1 до 4");
}
else if (i >= 5)
{
    Console.WriteLine("Введите номер от 1 до 4");
}

if (i == 1)
{
    Console.WriteLine("Диапозон I четверти: x > 0 до n ; y > 0 до n");
}
if (i == 2)
{
    Console.WriteLine("Диапозон II четверти: x < -0 до -n; y > 0 до n");
}
if (i == 3)
{
    Console.WriteLine("Диапозон III четверти: x < -0 до -n; y < -0 до -n");
}
if (i == 4)
{
    Console.WriteLine("Диапозон IV четверти: x > 0 до n; y < -0 до -n");
}
