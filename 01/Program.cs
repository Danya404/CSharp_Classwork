/* Написать программу, которая получает от пользователя число
 и выводит его квадрат */

/* Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} равен {square}"); */


/* Напишите программу, которая принимает на вход два числа и проверяет,
является ли первое число квадратом второго  */

/* Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите предполагаемый корень ранее введенного числа: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
    Console.Write($"Верно, {b} является корнем {a}");
else
    Console.Write($"Ошибка, {b} не является корнем {a}"); */


/* Напишите программу, которая будет выдавать название
дня недели по заданному номеру  */

//P.S. Мне было влом перебирать дни недели через конструкцию if-else,
//поэтому я сразу посмотрел, как работают массивы. Простите мне мою лень :)

/*string[] weekDays = {"Понедельник", "Вторник", "Среда",
 "Четверг", "Пятница", "Суббота", "Воскресенье"};

 Console.WriteLine("Введите целое число от 1 до 7: ");
 int num = Convert.ToInt32(Console.ReadLine());
 if (num < 1 | num > 7)
    Console.WriteLine("Некорректные данные");
 Console.WriteLine(weekDays[num - 1]); */

/* Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые числа в промежутке от -N до N  */

/* Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int negative_num = -num;
while (negative_num != num + 1)
{
    Console.Write($"{negative_num}, ");
    negative_num++;
} */


/* Напишите программу, которая на вход принимает трехзначное целое число, а на выходе показывает последнюю цифру этого числа */


Console.WriteLine("Введите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(num % 10);
