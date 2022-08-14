// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
while (a > 0)
{
    sum = sum + a % 10;
    a = a / 10;
    
}
Console.WriteLine("Сумма цыфр в числе равна: " + sum);