/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int SumNaturalNumbers(int numberOne, int numberTwo)
{
    if (numberOne==numberTwo)
    {
        return numberOne;
    }
    else if (numberOne>numberTwo)
    {
        return numberTwo+SumNaturalNumbers(numberOne,numberTwo+1);
    }
    else
    {
         return numberOne+SumNaturalNumbers(numberOne+1,numberTwo);

    }
}
Console.WriteLine("Поиск суммы натуральных чисел: ");
Console.Write("Введите значение M: ");
int numberOne=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int numberTwo=Convert.ToInt32(Console.ReadLine());
int result = SumNaturalNumbers(numberOne, numberTwo);
Console.WriteLine($"M = {numberOne}; N = {numberTwo} - > {result}");