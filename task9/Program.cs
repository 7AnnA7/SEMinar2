// выводит случайное число из отрезка [10;99] и показывает наибольшую цифру числа

int number = new Random (). Next (10, 100);
int FirstDigit = number/10;

Console.WriteLine($"Наше случайное число = {number}");

int SecondDigit = number%10;

Console.WriteLine($"Первая цифра = {FirstDigit} , вторая цифра {SecondDigit}");

if (FirstDigit > SecondDigit)
{
Console.WriteLine($"Первая цифра числа {number} больше. Это {FirstDigit}");
}

else
{
    Console.WriteLine($"Вторая цифра числа {number} больше. Это {SecondDigit}");
}