// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

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

(int, int) NegotivPositivSum(int[]arr)
{
    int posSum = 0;
    int negSum = 0;

    for(int i = 0; i < arr.Length;i++)
    {
        if(arr[i] > 0)
        {
            posSum=posSum+arr[i];
        }
        else
        {
            negSum+=arr[i];
        }
    }
    return(posSum, negSum);
}

void  PrintArr(int[]arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length-1;i++)
    {
        Console.Write(arr [i]+",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] arr = GenArr(12, -9, 9);
PrintArr(arr);
(int pos, int neg) sum = NegotivPositivSum(arr);
Console.WriteLine("Сумма > 0: "+sum.pos+" Сумма < 0: " +sum.neg);