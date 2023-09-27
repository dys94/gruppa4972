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

long MyPow(int a, int b)
{
    long res = 1;
    while(b > 0)
    {
        res=res*a;
        b=b-1;
    }
    return  res;
}

int a = ReadData("Введите целое число: ");
int b = ReadData("Введите целое число: ");
long res = MyPow(a, b);
PrintResult("Результат операции = " + res);