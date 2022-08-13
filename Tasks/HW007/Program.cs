// Определить количество цифр в числе
int x = int.Parse(Console.ReadLine() ?? "0");
int Sum = 0;
while (x > 0)
{
    x = x / 10;
    Sum++;
}
Console.WriteLine(Sum);