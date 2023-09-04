// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

Console.WriteLine();

int finishNum = 1;

string PrintNumber(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return(start + " " + PrintNumber(start - 1, end));
    
}
Console.WriteLine(PrintNumber(num, finishNum));