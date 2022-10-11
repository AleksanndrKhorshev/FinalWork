Console.WriteLine("Введите трехзначное число a");
int a = Convert.ToInt32 (Console.ReadLine ());
    if (99 < a && a < 999)
        {
            int x = a/10;
            int i = x%10;
            Console.WriteLine( "вторая цифра " + i);
        }
    else 
    {
        Console.WriteLine("Вы ввели некорректное число");
    }
