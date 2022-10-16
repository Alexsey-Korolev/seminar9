/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


int printRange(int A, int B)
{
    int result = A;
    if (A == B)
        return 0;
    else
    {
        A++;
        result = A + printRange(A, B);
        return result;
    }
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = printRange(A-1, B);
Console.WriteLine(result);