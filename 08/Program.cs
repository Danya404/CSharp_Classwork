// Задать двумерный массив. Написать программу, которая меняет местами первую и последнюю строку массива

// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
        
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j], 3} ");
//         }
//         Console.WriteLine();
//     } 
// }
// void Switch(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp =  matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//         matrix[matrix.GetLength(0) - 1, i] = temp;
//     } 
//     Console.WriteLine();
// }

// int[,] array2d = CreateMatrix(3, 4, 1, 10);
// PrintMatrix(array2d);
// Switch(array2d);
// PrintMatrix(array2d);


// Задать двухмерный массив. Написать программу, которая заменяет строки на столбцы. В случае, если это невозможно, сообщить об этом пользователю.

//  int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
        
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j], 3} ");
//         }
//         Console.WriteLine();
//     } 
// }
// void Switch(int[,] matrix)
// {
//     if (matrix.GetLength(0) != matrix.GetLength(1)) Console.WriteLine("Действие невозможно. Количество строк и столбцов не совпадает");
//     else
//         {
//             for (int i = 0; i < matrix.GetLength(0); i++)
//             {
//                 for (int j = 0; j < i; j++)
//                     {
//                         int temp =  matrix[i, j];
//                         matrix[i, j] = matrix[j, i];
//                         matrix[j, i] = temp;
//                     }
//             }
              
//             Console.WriteLine();
//         }
    
// }


// int[,] array2d = CreateMatrix(5, 5, 1, 10);
// PrintMatrix(array2d);
// Switch(array2d);
// PrintMatrix(array2d);

 int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine();
    } 
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int arrayIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[arrayIndex] = matrix[i, j];
            arrayIndex++;
        }
    }
    return array;
}

void FrequencyCounter(int[] array)
{
    int current = array[0];
    int counter = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == current)
        {
            counter++;
        }
        else 
        {
            Console.WriteLine($"Элемент {current} встречается в массиве {counter} раз");
            counter = 1;
            current = array[i];
        }
    }
    Console.WriteLine($"Элемент {current} встречается в массиве {counter} раз");
}


int[,] array2d = CreateMatrix(4, 4, 1, 10);
int[] array1d = MatrixToArray(array2d);
PrintMatrix(array2d);
PrintArray(array1d);
Array.Sort(array1d);
PrintArray(array1d);
FrequencyCounter(array1d);
