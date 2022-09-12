// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y=k1*x+b1, y=k2*x+b2
Console.WriteLine("Введите коээфициэнт k1 для первого уравнения прямой: ");
double coef1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коээфициэнт k2 для второго уравнения прямой: ");
double coef2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b1 для первого уравнения прямой: ");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2 для второго уравнения прямой: ");
double num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"y={coef1}*x+{num1}");
Console.WriteLine($"y={coef2}*x+{num2}");

double x = 0;
double y = 0;

x = (num2-num1)/(coef1-coef2);
y = coef1*x + num1;

Console.WriteLine($"Точка пересечения прямых: ({x};{y})");
