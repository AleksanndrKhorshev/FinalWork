Console.WriteLine("Введите цифру дня недели");
int day = Convert.ToInt32 (Console.ReadLine());
if ( day >= 0 & day <= 7)
 {
    if (day == 1) 
        Console.WriteLine("Понедельник");
    if (day == 2)
        Console.WriteLine("Вторник");
    if (day == 3) 
        Console.WriteLine("Среда");
    if (day == 4) 
        Console.WriteLine("Четверг");
    if (day == 5) 
        Console.WriteLine("Пятинца");
    if (day == 6) 
        Console.WriteLine("Суббота - Выходной!");
    if (day == 7) 
        Console.WriteLine("Воскресенье - Выходной!");
 }
else Console.WriteLine("В неделе семь дней..пора бы знать");