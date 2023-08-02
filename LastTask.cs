Console.Write("Введите значение M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N:");
int n = Convert.ToInt32(Console.ReadLine());
void number(int m, int n)
{
if (m > n)
return;
if (m % 2 == 0)
{
Console.Write($"{m} ");
}
number(m+1,n);
}
number(m,n);