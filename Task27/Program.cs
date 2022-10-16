Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int Summ(int n)
{
    int result = 0;
    while (n > 0)
    {
        result += n % 10;
        n = n / 10;
    }
    return result;
}
int Sum = Summ(n);
{
    Console.Write ($"Сумма цифр числа равна {Sum}");
}