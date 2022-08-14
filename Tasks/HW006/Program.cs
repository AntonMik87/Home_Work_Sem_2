// Найти сумму чисел от 1 до А
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine() ?? "0");
int x = 1;
while (x <= n)
{
    Console.Write(x + " ");
    x++;
}
Console.WriteLine("Cумма чисел = " + n*(n+1)/2 );