int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num= int.Parse(Console.ReadLine()??"0");
    return num;
}

string BuildLine(int num, int pow)
{
    string  res = string.Empty;
    for (int i = 1; i <= num; i++)
    {
        res = res + Math.Pow(i, pow) + "  ";
    }
    return res;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int n = ReadData("Число");
PrintResult(BuildLine(n, 1));
PrintResult(BuildLine(n, 2));