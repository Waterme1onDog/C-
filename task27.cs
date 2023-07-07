int number = Prompt("Введите число:");
int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int SumAllDigit(int number)
{
    int result = 0;
    while (number>0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
Console.Write($"Сумма цифр в чесле {number} = {SumAllDigit(number)}");