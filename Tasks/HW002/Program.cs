﻿// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите число A затем B");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = int.Parse(Console.ReadLine() ?? "0");

int x = a * a;


Console.WriteLine("Квадрат числа A = " + x);

if (x == b)
{
    Console.WriteLine("Числа A являются квадратом числа B: " + x + " = " + b);
}
else
{
    Console.WriteLine("Число B не является квадратом числа A");
}


