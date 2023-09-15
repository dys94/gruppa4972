Console.WriteLine("Введите число:"); // Выводим текст на консоль
string input = Console.ReadLine(); // Принимаем с клавиатуры текст и объявляем переменную с именем input и типом string
if(input.Length != 1)
{
    return; //если длинна строки не ровно 1, то возвращаем 
}

bool isDigits = int.TryParse(input, out int digits); //Преобразование из строкового в числовое
if(isDigits)
{
    if(digits > 5) 
    {
        Console.WriteLine("Выходной"); 
    }
    else {
        Console.WriteLine("не выходной"); // выводим текст на консоль
    }
}