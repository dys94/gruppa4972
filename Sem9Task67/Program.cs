int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int digitSum(int num)
{

    if(num > 0)
    {
    return  digitSum(num/10)+num%10;
    } else return 0;

}

int num = ReadData("Введите число");
Console.WriteLine($"Сумма цифр { digitSum(num)}");