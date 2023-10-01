// Задача №32
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] GenArr(int len, int lowBorder, int highBorder) 


{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write($"[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
    System.Console.WriteLine();
}

void InversArray(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        arr[i]*=-1;
    }
}

int[] array=GenArr(12,-9,9);
PrintArray(array);
InversArray(array);
PrintArray(array);