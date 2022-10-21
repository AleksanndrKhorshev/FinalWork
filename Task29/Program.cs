void FillArray(int[]collection)
 {
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection [index] = new Random().Next(-1000,1000);
        index++;
    }

 }

void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

FillArray(array);
PrintArray(array);