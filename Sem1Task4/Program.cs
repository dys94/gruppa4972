Console.WriteLine("Введите три числа");
Console.WriteLine("Первое число:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Второе число:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Третье число:");
int num3 = int.Parse(Console.ReadLine());

int maxNum = 0;

if (num1 > maxNum) maxNum = num1;
if (num2 > maxNum) maxNum = num2;
if (num3 > maxNum) maxNum = num3;

Console.Write("Максимальное значение имеет число " + maxNum);