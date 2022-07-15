// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.


Console.WriteLine("Введите число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

int result = numberFirst % numberSecond;

if (result == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Некратно, остаток от деления = {result}");
}