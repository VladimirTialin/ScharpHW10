/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/
    decimal AckermanFunction(decimal numberOne, decimal numberTwo)
    {
    if (numberOne == 0)
    {
        return numberTwo + 1;
    }
    else if ((numberOne != 0) && (numberTwo == 0))
    {
        return AckermanFunction(numberOne - 1, 1);
    }
    else
    {
        return AckermanFunction(numberOne - 1, AckermanFunction(numberOne, numberTwo - 1));
    }
    }
Console.WriteLine("Вычисляем функцию Аккермана: ");
Console.Write("Введите значение m: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if(numberOne<0 || numberTwo<0)
{
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine("Вы ввели отрицательное число!\nФункция Аккермана расчитывается для положительных чисел. Повторите ввод!");
    Console.ResetColor();
}
else
{
decimal result = AckermanFunction(numberOne, numberTwo);
Console.WriteLine(result);
}
