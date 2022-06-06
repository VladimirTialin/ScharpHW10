/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "5, 4, 3, 2, 1"
M = 8; N = 4. -> "8, 7,6, 5, 4"
*/

string NumbersInRange(int numberOne, int numberTwo)
{
    if (numberOne > numberTwo)
    {
        return NumbersInRange(numberOne, numberTwo+1) + ", " + numberTwo;
    }
    else if(numberOne < numberTwo)
    {
        return NumbersInRange(numberOne+1, numberTwo) + ", " + numberOne;
    }
    {
        return Convert.ToString(numberTwo);
    }
}
Console.WriteLine("Поиск натуральных чисел в промежутке от M до N: ");
Console.Write("Введите значение M: ");
int numberOne=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int numberTwo=Convert.ToInt32(Console.ReadLine());
string result = NumbersInRange(numberOne, numberTwo);
Console.WriteLine($"M = {numberOne}; N = {numberTwo}. - > {result}");