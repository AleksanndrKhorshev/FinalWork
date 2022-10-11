Console.WriteLine("Введите положительное целое число");
int n = Convert.ToInt32 (Console.ReadLine ());
    if(n > 100)
    {   while ( n >= 1000)
    
            n = n/10;
       
        {
            int x = n%100;
            int i = x%10;
        Console.WriteLine( "третья цифра " + i);
        }
    }
    else 
    {
        Console.WriteLine( "третья цифра в числе " + n + " отсутствует");
    }