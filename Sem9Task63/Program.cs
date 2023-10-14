int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine()?? "0");
    return number;
}

// N=5 -> 5 4 3 2 1
void GenLineRec(int num)
{
    Console.WriteLine(" "+num);
    if(num<=1)
    {
    }
    else
    {
    GenLineRec(num - 1);
    }
}

int num = ReadData("Введите число N: ");
GenLineRec(num);