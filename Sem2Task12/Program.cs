int numA = int.Parse(Console.ReadLine()?? "0");
int numB = int.Parse(Console.ReadLine()?? "0");
if (numB % numA == 0)
{
    Console.WriteLine("ПервоеКратноВторому");
}

else
{
    Console.WriteLine("ВтороеНеКратноПервому, остаток  от деление" + numB % numA);
}