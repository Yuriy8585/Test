// Напишите программу, которая на вход принимает слово и проверяет, является ли оно палиндромом

Console.Clear();
Console.WriteLine("Enter WORD = ");

string text = Console.ReadLine()!;
string newText = "";

int len = text.Length;

for (int i = 0; i < len; i++)
{
    bool check = newText.Contains(text[i]);
    if (!check)
    {
        newText += text[i];
    }
    else
    {
        string elem = (text[i]).ToString();
        newText = newText.Replace(elem, "");
    }
}

if (newText.Length < 2) 
{ 
    Console.WriteLine("PALL");
}
else 
{
    Console.WriteLine("NOT PALL");
}
