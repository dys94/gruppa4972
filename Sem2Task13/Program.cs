Console.WriteLine("Введите число:"); // Выводим текст на консоль
string input = Console.ReadLine(); // Принимаем с клавиатуры текст и объявляем переменную с именем input и типом string
if(input.Length >= 3) 
{
    Console.WriteLine(input[2]); // если длинна строки больше-ровно 3, то выводим второе число
}
else {
    Console.WriteLine("число"); // выводим текст на консоль
}