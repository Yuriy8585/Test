// Орел
Console.Clear();

Random rnd = new Random();
            int a = 0;
            int b = 0;
            int c = 100;
 
            Console.WriteLine("Орел или Решка");
            while (true)
            {
 
                Console.WriteLine("Введите число");
                int i1 = rnd.Next(0, 2);
                    string i = Console.ReadLine();
                
                while (true)
                {
                    if (i == "1" || i == "0")
                    {
                        break;
                    }
                    else if(i == "Результат")
                    {
                        c = c / (a + b) * a ;
                        Console.WriteLine($"Побед {a}. Поражений {b}. Ваша удача:{c}%");
                        Console.WriteLine("Введите число");
                        i = Console.ReadLine();
                        if (i == "0" || i == "1")
                        {
                          
                            break;
                        }
                       
                    }
                     else
                    {
                        Console.WriteLine("Введите 0 или 1");
                        i = Console.ReadLine();
                    }
                }
                if (i1 == Convert.ToInt32(i))
                {
                    Console.WriteLine("Орел");
                    a++;
                    break;
                }
                else
                {
                    Console.WriteLine("Решка");
                    b++;
                    
                    break;
                        
                }
                
            }