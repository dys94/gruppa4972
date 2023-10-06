// Ввод парметров матрицы.
int countRow = ReadInt("Введите количество строк m: ");
int countColumn = ReadInt("Введите количество cтолбцов n: ");

// Генерация и вывод матрицы.
int minValue = -10;
int maxValue = 10;
double[,] matrix = CreateRandomMatrix(countRow, countColumn, minValue, maxValue);
PrintMatrix(matrix);


// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генераци двумерного массива, заполненного случайными вещественными значениями.
double[,] CreateRandomMatrix(int countRow, int countColumn, int minValue, int maxValue)
{
    Random random = new Random();
    double[,] matrix = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            matrix[i, j] = (maxValue - minValue) * random.NextDouble() + minValue;
        }
    }
    return matrix;
}
// Вывод двумерного массива на экран.