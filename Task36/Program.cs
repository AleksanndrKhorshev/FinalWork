int[] NewArray(int length)
{
    int[] x = new int[length];
    Random a = new Random();
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = a.Next(1, 99);
    }
    return x;
}
 
int Sum(int[] a)
{
   
    int sum = 0;
    for (int i = 1; i < a.Length; i = i + 2)
    {
        sum = sum + a[i];
    }
    return sum;
}
 
void printArray(int[] col)
{
    int count = 0;
    while (count < col.Length)
    {
        System.Console.Write($"{col[count]}  ");
        count++;
    }
    System.Console.WriteLine();
}
 
 Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = NewArray(N);
printArray(arr);
Console.Write ("сумма нечетных элементов "); System.Console.Write(Sum(arr));