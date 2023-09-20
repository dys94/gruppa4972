int number=ReadInt("Введите число N: ");
for(int i = 1;  i <= number; i++)
{
    Console.Write($"{i*i*i} ");
}
    int  ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

