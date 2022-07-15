// принимает на вход два числа и проверяет, является ли одно число квадратом другого

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int squareA = numberA * numberA;
int squareB = numberB * numberB;

if ( numberA == squareB || numberB == squareA)
{
    Console.WriteLine("первое число - квадрат второго или второе число - квадрат первого");
}
else
{
    Console.WriteLine("первое число - не квадрат второго или второе число - не квадрат первого");
}
