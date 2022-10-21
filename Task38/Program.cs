double [] NewArray(int length)
{
    double [] x = new double[length];
    Random a = new Random();
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = a.Next(1, 99);
    }
    return x;
}

void printArray(double[] col)
{
    int count = 0;
    while (count < col.Length)
    {
        System.Console.Write($"{col[count]}  ");
        count++;
    }
    System.Console.WriteLine();
}

double Diff(double[] a)
{
    double max = a[0];
    double min = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] > max)
        {
            max = a[i];
        }
         if (a[i] < min)
        {
            min = a[i];
        }
    }
    return max-min;
}

Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());

double[] arr = NewArray(N);
printArray(arr);
Console.Write("Макс - мин = "); System.Console.WriteLine(Diff(arr));
 