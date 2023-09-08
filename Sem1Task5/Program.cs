int  a = int.Parse(Console.ReadLine()??"0");
if (a < 0) a = -a;
for (int i = -a; i <= a; i++){
    Console.Write(i);
    Console.Write(" ");
}