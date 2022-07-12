/* Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */

// - k1*x + y = b1;
// - k2*x + y = b2;

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}


(double, double) Solve(double k1, double b1, double k2, double b2)
{
    double detA = -1 * k1 - -1 * k2;
    if (detA != 0)
    {
        System.Console.WriteLine("test " + k1);
        System.Console.WriteLine("det = " + detA);
        double x = (b1 - b2) / detA;
        double y = (-1 * k1 * b2 - -1 * k2 * b1) / detA;
        (double, double) res = (x, y);
        return res;
    }
    else return (0,0);
}

int k1 = Prompt("k1= ");
int b1 = Prompt("b1= ");
int k2 = Prompt("k2= ");
int b2 = Prompt("b2= ");

System.Console.WriteLine(Solve(k1, b1, k2, b2));