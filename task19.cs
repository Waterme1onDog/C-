Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int reminder; 
int reverse = 0;
int safeinpitnumber = number;
    while (number > 0)
{
    reminder = number % 10;
    reverse = (reverse * 10) + reminder;
    number = number / 10;
} 
   if (safeinpitnumber==reverse)
{
    Console.Write($"Число {safeinpitnumber} является палиндромом");
}
    else
{
    Console.Write($"Число {safeinpitnumber} не является палиндромом!!!");
}
      