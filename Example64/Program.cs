/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "5, 4, 3, 2, 1"
M = 8; N = 4. -> "8, 7,6, 5, 4"
*/

string Number(int numberOne, int numberTwo)
{
    if (numberOne > numberTwo)
    {
        return Number(numberOne, numberTwo+1) + ", " + numberTwo;
    }
    else
    {
        return Convert.ToString(numberTwo);
    }
}
Console.WriteLine("Введите 2 числа: ");
int numberOne=Convert.ToInt32(Console.ReadLine());
int numberTwo=Convert.ToInt32(Console.ReadLine());
string result = Number(numberOne, numberTwo);
Console.WriteLine($"M = {numberOne}; N = {numberTwo}. - > {result}");