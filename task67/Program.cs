// Задача 67: Напишите программу, которая будет принимать на вход 
// число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int ReturnSumNum(int num)
{
    if (num == 0)
    {
       return 0;
    }
    else
    {
        return ReturnSumNum(num / 10) + num % 10;
    }
}
Console.Write("Введите число M: ");
int num1 = InputNumber();
Console.WriteLine(ReturnSumNum(num1));