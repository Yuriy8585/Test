//напишите программу которая принимает на вход трехзначное число а на выходе показывает последнюю цифру этого числа
//456 -> 6
//782 -> 2

Console.Write("Enter int N = ");
int N = int.Parse(Console.ReadLine());

int a = 0;
double b = 0;

a = N%10;
b = N/10;

Console.WriteLine("Cut" + " " + a);
Console.Write("Previous Numbers" + " " + b);


