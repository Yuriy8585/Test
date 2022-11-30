//Напиите программу которая на вход принимает одно число N, а выводит значения все целые числа от -N до N

Console.Write("Enter int N = ");
int N = int.Parse(Console.ReadLine());
int a = -N;
while (a < N+1)
{
    Console.Write(" " + a + " ");
    a = a + 1;
}
