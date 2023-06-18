int firstnumber = 1;
Console.WriteLine("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Чётные числа от 1 до {numN}");
while (firstnumber <= numN)
{
    if (firstnumber % 2 !=1)
    {
        Console.Write(firstnumber + ", ");
    }
    firstnumber++;
}
