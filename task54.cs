Console.Write("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбиков:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];

void mas(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(0, 10);
        }
    }
}

void printArray(int[,] array)
{
    int i, j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
        }
        Console.WriteLine();
    }

}

mas(m, n);
Console.WriteLine("Исходный массив:");
printArray(randomArray);

void bubble(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
bubble(randomArray);
Console.WriteLine("Отсортированный массив:");
printArray(randomArray);