/* Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int start = 1;
int result = 0;
while (start <= num)
{
   result += start;
   start++;
}

Console.WriteLine(result); */

/* Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numlenght = NumLenght(number);
Console.WriteLine($"Длина числа {number}: {numlenght}");

int NumLenght(int num)
{
    int count = 0;
    while (num != 0) 
    {
        num /= 10;
        count++;
    }
    return count;
} */

int[] array = new int[8];
RandArray(array);
PrintArray(array);
void RandArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 2);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}