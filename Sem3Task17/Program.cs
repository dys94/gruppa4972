//ввести x
//ввести y
//поиск ответа
//вывести результат

//вводим  данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

//по  координатом точки определяем номер четверти
int QuterTest(int x, int y)
{
    if(x > 0 && y > 0)  return 1;
    if(x < 0 && y > 0)  return 2;
    if(x < 0 && y < 0)  return 3;
    if(x > 0 && y < 0)  return 4;
    return 0;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.Write(msg);
}

int x = ReadData("Введите кординаты x: ");
int y = ReadData("Введите кординаты y: ");

int res = QuterTest(x, y);

PrintResult("Точка находится в четверти № "+res);