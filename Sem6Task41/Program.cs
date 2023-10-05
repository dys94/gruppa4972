// Вывод сообщения и запись введённых данных
string[] input = Console.ReadLine().Split(' ');

int count = 0;
for (int i = 0; i < input.Length; i++)
    if (int.Parse(input[i]) > 0)
    count++;

System.Console.WriteLine(count); 