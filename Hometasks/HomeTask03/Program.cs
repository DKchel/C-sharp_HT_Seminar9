// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе неотрицательное число");
int num2 = int.Parse(Console.ReadLine());


Console.WriteLine();

int AkkermanN = num;
int AkkermanM = num2;

if ((AkkermanN < 0) || (AkkermanM < 0)) { Console.WriteLine("Не корректный ввод чисел");}

else { Console.WriteLine(AkkermanFun(AkkermanN, AkkermanM)); }

int AkkermanFun(int AkkermanN, int AkkermanM)
{
    if (AkkermanN == 0)
        return AkkermanM + 1;
    else
      if ((AkkermanN != 0) && (AkkermanM == 0))
        return AkkermanFun(AkkermanN - 1, 1);
    else
        return AkkermanFun(AkkermanN - 1, AkkermanFun(AkkermanN, AkkermanM - 1));
}

// Совершенно не понял как работает расчёт (нашёл в интернете стр. 21 - 30 применив свои названия аргументов и функции)