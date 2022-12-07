// Орел
Console.Clear();

int count = 0;
int countOrel = 0;
int countReshka = 0;

while(true)
{
    Console.WriteLine("Enter Number = ");
    int num = int.Parse(Console.ReadLine());  //ручной ввод
    //int num = new Random().Next(0, 2);      //автоматический
    if (num == 0)
    {
        Console.WriteLine("OREL");
        countOrel++;
        countReshka = 0;
    }
    else
    {
        Console.WriteLine("RESHKA");
        countReshka++;
        countOrel = 0;
    }
    count++;
    if (countOrel == 3 || countReshka == 3)
    {
        Console.Write($"Made {count} try");
        break;
    }
}