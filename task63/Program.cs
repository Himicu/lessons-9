﻿// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void NatureNum(int num){
    if(num != 0){
        NatureNum(num - 1);
        Console.Write($"{num} ");
    }
    
}
Console.Write("Введите число N: ");
int num = InputNumber();
NatureNum(num);