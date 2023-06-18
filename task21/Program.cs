double hypotenuse (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distX = x2-x1;
    double distY = y2-y1;
    double distZ = z2-z1;
    double result = Math.Sqrt(distX*distX + distY*distY + distZ*distZ);
    return result;
}
Console.Write("Введте значение x1 :");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введте значение y1 :");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введте значение z1 :");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введте значение x2 :");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введте значение y2 :");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введте значение z2 :");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.Write ($"Расстояние между точками 1 и 2 составляет - {hypotenuse(x1,y1,z1,x2,y2,z2)}");