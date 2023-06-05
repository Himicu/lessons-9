// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int ReturnDegreeNum(int num, int num1)
{
    if (num1 == 1)
    {
       return num;
    }
    else
    {
        return num * ReturnDegreeNum(num, num1 -1);
    }
}
Console.Write("Введите число M: ");
int num1 = InputNumber();
Console.Write("Введите число N: ");
int num2 = InputNumber();
Console.WriteLine(ReturnDegreeNum(num1, num2));