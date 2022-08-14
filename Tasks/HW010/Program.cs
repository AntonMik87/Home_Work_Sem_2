// Показать кубы чисел, заканчивающихся на четную цифру       // "\t"
int a = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
int ch;
while (i <= a)
{
    ch = (i * i * i);
    i++;
    if (ch % 2 == 0)
    {
        Console.Write(ch + " ");
        
    }
}

