int numA = int.Parse(Console.ReadLine()?? "0");
int numB = int.Parse(Console.ReadLine()?? "0");
bool test1 = (numA == numB * numB);
bool test2 = (numB == numA * numA);
if (test1) Console.WriteLine("ПервоеКвадратВторого");
if (test2) Console.WriteLine("ВтороеКвадратПервого");
if (!(test1 || test2))
{
    Console.WriteLine("Числа не квадратные");
}