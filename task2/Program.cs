// See https://aka.ms/new-console-template for more information
//Напишите программу, которая будет выдавать дни недели
// a = 1 -> понедельник
// a = 2 -> вторник
// a = 3 -> среда
// a = 4 -> четверг
// a = 5 -> пятница
// a = 6 -> суббота
// a = 7 -> Воскресенье

Console.Write("Enter Number week a = ");

int a = int.Parse(Console.ReadLine());
if (a == 1)
{
    Console.Write("Monday");

}

if (a == 2)
{
    Console.Write("Tuesday");

}
if (a == 3)
{
    Console.Write("Wednesday");

}
if (a == 4)
{
    Console.Write("Thursday");

}
if (a == 5)
{
    Console.Write("Friday");

}
if (a == 6)
{
    Console.Write("Saturday");

}
if (a == 7)
{
    Console.Write("Sunday");

}
else 
{
    Console.Write("Not Found");
}
