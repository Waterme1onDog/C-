Console.Write("Введите трехзначное число: ");
int TripleNumUser = Convert.ToInt32(Console.ReadLine());
int TripleNum = TripleNumUser;
    TripleNum = TripleNum /10; 
    TripleNum = TripleNum %10;
Console.WriteLine($"Вторая цифра числа {TripleNumUser} = {TripleNum}");
