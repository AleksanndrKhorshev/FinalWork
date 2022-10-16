Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите степень числа");
int a = Convert.ToInt32 (Console.ReadLine ());
int i = 2;
int St = n;
if (a == 0)
    {
        St = 1;
    }
while ( i <=a)
    {
        St = St*n;
        i++;
    }

 Console.WriteLine($"{n} в степени {a} равно {St}");