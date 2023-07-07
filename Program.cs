Console.Write("Введите значение числа А:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение числа B:");
int numberB = Convert.ToInt32(Console.ReadLine());
int sumNaturalDegree = 0;
int sum = numberA;
    for (int counterB = 1; counterB < numberB ; counterB++)
    {
      sumNaturalDegree = numberA * sum ;
      sum = sumNaturalDegree ;
    }
Console.Write($"Число {numberA} в натуральной степени числа {numberB} = {sum}");