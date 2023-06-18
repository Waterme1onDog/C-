Console.Write("Введите число дня недели от 1 до 7: ");
int DayWeek = Convert.ToInt32(Console.ReadLine());
    if (DayWeek >= 6 && DayWeek <=7 )
    {
        Console.Write($"{DayWeek} - да, это число является выходным днем ");
    }
    else
    {
        Console.Write($"{DayWeek} - нет, это число не является выходным днем!!! ");
    }