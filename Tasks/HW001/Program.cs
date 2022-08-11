// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число от 1 до 7");
int a = int.Parse(Console.ReadLine());

if (a <= 5 && a <= 7)
{
    Console.WriteLine("Будни");
}
else
{
    Console.WriteLine("Выходной");
}
