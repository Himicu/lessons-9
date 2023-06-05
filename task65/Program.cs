// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void NatureNum(int start, int end)
{
    if (end == start)
        Console.Write($"{start} ");
    else
    {
        NatureNum(start, end - 1);
        Console.Write($"{end} ");
    }
}
Console.Write("Введите число M: ");
int num1 = InputNumber();
Console.Write("Введите число N: ");
int num2 = InputNumber();
if (num1 > num2)
    (num1, num2) = (num2, num1);
NatureNum(num1, num2);