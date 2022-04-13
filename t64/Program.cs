/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M.
M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 7
 */

System.Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
PrintNumber(numberM, numberN);

void PrintNumber(int n, int printNumber)
{
    System.Console.Write($"{printNumber} ");
    if (printNumber > n)
    {
        PrintNumber(n, printNumber - 1);
    }
}
