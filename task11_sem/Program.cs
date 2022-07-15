// выводит случайное трёхзначное число и удаляет его вторую цифру

int number = new Random (). Next (100, 1000);
int NumberFirst = number/100;
int NumberSecond = number%10;
int Rezult = NumberFirst*10 + NumberSecond;
Console.WriteLine($"Наше случайное число = {number} , исключая среднюю цифру = {Rezult}");
