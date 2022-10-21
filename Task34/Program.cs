int[] NewArray(int length)
{
    int[] x = new int[length];
    Random a = new Random();
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = a.Next(100, 999);
    }
    return x;
}
 
int CountElements(int[] a)
{
   
    int Count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i]%2 == 0)
        {
           
            Count++;
        }
    }
    return Count;
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
Console.Write ("число четных чисел "); System.Console.Write(CountElements(arr));