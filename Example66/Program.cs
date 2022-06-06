/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int Number(int numberOne, int numberTwo)
{
    if (numberOne==numberTwo)
    {
        return numberOne;
    }
    else if (numberOne>numberTwo)
    {
        return numberTwo+Number(numberOne,numberTwo+1);
    }
    else
    {
         return numberOne+Number(numberOne+1,numberTwo);

    }
}
Console.WriteLine("Введите 2 числа: ");
int numberOne=Convert.ToInt32(Console.ReadLine());
int numberTwo=Convert.ToInt32(Console.ReadLine());
int result = Number(numberOne, numberTwo);
Console.WriteLine($"M = {numberOne}; N = {numberTwo} - > {result}");