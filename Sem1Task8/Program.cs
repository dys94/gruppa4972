﻿Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()??"0");
int count = 0;

if (num % 2 != 0)
{
    num = num - 1;
}
while (count < num)
{
    {
        count = count + 2;
        Console.WriteLine(count);
    }
}
