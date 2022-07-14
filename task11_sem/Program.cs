// выводит случайное трёхзначное число и удаляет его вторую цифру

int number = new Random (). Next (100, 1000);
int dijit3 = number%10;
int dijit1 = number/100;
int result = dijit1*10 + dijit3;
Console.WriteLine(result);