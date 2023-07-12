int positiveNumber = 0;
Random rnd = new Random();
int a = rnd.Next(100,999);
int b = rnd.Next(100,999);
int c = rnd.Next(100,999);
int d = rnd.Next(100,999);
int[] array = {a,b,c,d};
foreach (int i in array)
{
    if (i % 2 == 0 )
    {
       positiveNumber++;
    }
    System.Console.Write("{0} ", i);
}
System.Console.Write($"Массив имеет {positiveNumber} чётных чисел ");