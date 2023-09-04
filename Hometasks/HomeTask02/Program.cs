// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());


Console.WriteLine();

int startNum = num;
int endNum = num2;

if (num < num2) {Console.WriteLine(SumNumbers(startNum, endNum));}

if (num > num2) {Console.WriteLine(SumNumbers(endNum, startNum));}

if (num == num2) {Console.WriteLine("Числа равны, расчёт суммы натуральных элементов промежутка не возможен");} 

int SumNumbers(int start, int end)
{
    if (start == end) {return start;}
    return(start + SumNumbers(start + 1, end));
}
