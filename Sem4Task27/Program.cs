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

int SumDigit(int num)
{
    int res = 0;
    while(num > 0)
    {
        res=res+num%10;
        num=num/10;
    }
    return res;
}

int num = ReadData("Введите целое число: ");
int res = SumDigit(num);
PrintResult(" " +res);
