Console.WriteLine("Введите число n");
int n = Convert.ToInt32 (Console.ReadLine ());
int max = n;
    for (int i = 2; i <= n; i += 2)
        Console.Write(i + " ");
