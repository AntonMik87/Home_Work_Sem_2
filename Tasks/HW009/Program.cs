// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine() ?? "0");

int fact = 1;
int i = 1;
while (i <= n)
{
    fact = fact * i;
    i++;
}
Console.WriteLine("Произведение чисел: " + fact);