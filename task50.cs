Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
int lines = 3;
int columns = 4;
double[,] numbers = new double[lines, columns];
fillArrayRandomNumbers(numbers);
printArray(numbers);

void fillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(0, 10));
        }
    }
}

void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
if (pos1 < 0 | pos1 > numbers.GetLength(0) - 1 | pos2 < 0 | pos2 > numbers.GetLength(1) - 1)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine("Цифра указанного эелемента = {0}", numbers[pos1, pos2]);
}