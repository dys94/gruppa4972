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

long Factorial(int num)
{
    long  res = 1;
    for (int i = 2; i<=num; i++)
    {
        res = res*i;
    }
    return res;
}

int num = ReadData("Введите целое число: ");
long res = Factorial(num);
PrintResult("Факториал числа " + num + " равен " + res);