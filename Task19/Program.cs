Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());
if ( N > 9999 & N  < 100000 )
    {
    int a = N/10000;

    int x = N/1000;
    int b = x%10;

    int y = N/10;
    int c = y%10;

    int d = N%10;
    if (a == d & a == d)
        {
            Console.WriteLine("Число палиндром");
        }
     
    else 
        {
            Console.WriteLine( "число не палиндром");
        }
    }
else Console.WriteLine("Число не пятизначное");