double[] array = new double[5];
Random rand = new Random();
double maxNumber = array[0];
double minNumber = array[0];
double difNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100) + rand.NextDouble() ;                               //Создаем вещественный массив

    if (array[i] < minNumber )                                                          //Вычисляем меньшее и большее значение
    {
        minNumber = array[i];
    }
    if(array[i] > maxNumber)
    {
        maxNumber=array[i];
    }                                                      
}                                                                      
difNumbers = maxNumber + minNumber ;                                                                          //Складываем меньшее  и большее 
var str = string.Join(" ", array);Console.WriteLine(str);                                                     //Выводим массив , округляем ответ
Console.WriteLine(string.Format("{0:F1}", ($"Минимальное значение = {minNumber}")));
Console.WriteLine(string.Format("{0:F1}", ($"Максимальное значени = {maxNumber}"))); 
Console.WriteLine($"Разница между минимальным и максимальным значением = {Math.Round(difNumbers,2)} ");






