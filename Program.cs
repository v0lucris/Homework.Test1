//По заданному номеру дня недели вывести его название
int a1 = 1;
int a2 = 2;
int a3 = 3;
int a4 = 4;
int a5 = 5;
int a6 = 6;
int a7 = 7;

Console.WriteLine("Введи номер дня недели : ");
int b = int.Parse(Console.ReadLine());
if (b == a1)
{
     Console.WriteLine("Понедельник");
}
else if (b == a2)
{
     Console.WriteLine("Вторник");
}
else if (b == a3)
{
     Console.WriteLine("Среда");
}
else if (b == a4)
{
     Console.WriteLine("Четверг");
}
else if (b == a5)
{
     Console.WriteLine("Пятница");
}
else if (b == a6)
{
     Console.WriteLine("Суббота");
}
else if (b == a7)
{
     Console.WriteLine("Воскресенье");
}
else
Console.WriteLine("Неделька то закончилась");
