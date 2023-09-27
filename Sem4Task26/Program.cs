int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

void PrintResult(string msg)
{
    Console.Write(msg);
}

int NumDigits(int num)
{
    int count = 0;
    while (num > 0)
    {
        count++;
        num=num/10;
    }
    return count;
}

int num = ReadData("Введите число: ");
Console.WriteLine("Кол-во цифр в числе = " + NumDigits(num));