Console.Write("Введите значение N для вычисления таблицы кубов:");
int numberN = Convert.ToInt32(Console.ReadLine());
for (int i=1;i<=numberN;i++)
{
int cubenumbers = i*i*i;
Console.Write($"{cubenumbers} ");
}
