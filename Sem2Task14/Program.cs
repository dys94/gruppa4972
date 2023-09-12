Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()?? "0");

Console.WriteLine(num % 7 == 0 && num % 23 == 0 ? "Кратно" : "Не кратно");