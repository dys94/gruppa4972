﻿// int day = int.Parse(Console.ReadLine()??"0");
// string[] dayOfWeek = new string[7];
// dayOfWeek[0] = "Понедельник";
// dayOfWeek[1] = "Вторник";
// dayOfWeek[2] = "Среда";
// dayOfWeek[3] = "Четверг";
// dayOfWeek[4] = "Пятница";
// dayOfWeek[5] = "Суббота";
// dayOfWeek[6] = "Воскресение";
// Console.WriteLine(dayOfWeek[day-1]);

Console.WriteLine("Enter day number");
int dayNum = int.Parse(Console.ReadLine());

string outDayWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum-1));

Console.WriteLine(outDayWeek);
