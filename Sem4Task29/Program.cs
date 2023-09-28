int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

int[] Arrey = new int[8];
Console.Write("");
for (int i = 0; i < Arrey.Length; i++)
{
    Arrey[i] = new Random().Next(0, 9);
    Console.Write(Arrey[i]);
}