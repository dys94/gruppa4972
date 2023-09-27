//вводим число от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}


//выводим результат
void PrintResult(string msg)
{
    Console.Write(msg);
}

int SimpleSum(int numA)
{
    int sumOfNumber=0;
    for(int i=1; i<=numA;i++)
    {
        sumOfNumber+=i;
    }
    return sumOfNumber;
}

int GausseSum(int numA)
{
    int sumOfNumber = 0;
    sumOfNumber=(numA*(numA))/2;
    return sumOfNumber;
}


int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
int res1 = SimpleSum(numberA);
Console.WriteLine(DateTime.Now-d1);

DateTime d2 = DateTime.Now;
int res2 = GausseSum(numberA);
Console.WriteLine(DateTime.Now-d2);

PrintResult("Сумма чисел от 1 до "+ numberA + " (простой)равна " + res1);
PrintResult("Сумма чисел от 1 до "+ numberA + " (гаус)равна " + res2);

//вводим число от пользователя
//вычисляем сумму
//выводим результат