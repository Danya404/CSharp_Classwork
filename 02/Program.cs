int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка от 10 до 99 -> {num}");
int firstnum = num / 10;
int secondnum = num % 10;
if (firstnum > secondnum) Console.WriteLine($"Наибольшая цифра числа -> {firstnum}");
else Console.WriteLine($"Наибольшая цифра числа -> {secondnum}");
 