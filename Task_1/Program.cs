/* Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void CalcPositiveElements(int i = 0, int res = 0)
{
     
    if (i >  0) 
    {
        res++;
        System.Console.WriteLine("Total Positive Elements = " + res);
        
    }
    i = Prompt("Enter a number: ");
    CalcPositiveElements(i, res);
}

CalcPositiveElements();