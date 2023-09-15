Console.WriteLine("Введите трехзначное  число:  "); // Выводим текст "Введите трехзначное  число" на консоль
string line = Console.ReadLine(); //объявляем переменную с именем line и типом string
char[] digits = line.ToCharArray(); //копирует знаки данного экземпляра в массив
Console.WriteLine(digits[1]); // выводит ответ в консоль