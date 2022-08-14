// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine() ?? "0");
int i = 1;

while (i <= a)
{
    Console.Write(i*i*i + " ");
    i++;
}
