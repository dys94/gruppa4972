Console.WriteLine("Введите число: ");

string? inputNum = Console.ReadLine();

if (inputNum!= null)
// {
//     int num = int.Parse(inputNum);

//     int res = num*num;

//     Console.WriteLine(res);
// }


Console.WriteLine("Квадрат числа: "+(int)Math.Pow(int.Parse(inputNum), 2));