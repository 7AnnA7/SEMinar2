// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


Console.WriteLine("Введите число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
int delenie1 = numberFirst%7;
int delenie2 = numberFirst%23;

if (delenie1 == 0 && delenie2 == 0)
{
    Console.WriteLine("Кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine("Некратно одновременно 7 и 23");
}
