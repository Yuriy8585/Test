// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Написать программу которая на вход принимает число и выдает его квадрат (число умноженное на само себя)
//Например
//4->16
//-3->9
//-7->49

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());

int sqrt = number * number;
Console.WriteLine("Квадрат числа = " + sqrt);
