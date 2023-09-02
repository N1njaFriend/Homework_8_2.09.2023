// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

bool isValidInput = false;
int result = 0;

do
{
    Console.Write("Введите размерность: ");
    isValidInput = int.TryParse(Console.ReadLine(), out result);

    if (!isValidInput)
    {
        Console.WriteLine("Пожалуйста, введите число.");
    }
} while (!isValidInput);

int[,] matrix = new int[result,result];

void GetArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,10);

            
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CutArray()
{
    int minRow=0;
    int minSumRow=0;
    int sumRow=0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        
        sumRow += matrix[i, j];
        
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    System.Console.WriteLine(minSumRow + 1);
}

GetArray();
PrintArray(matrix);
System.Console.WriteLine();
CutArray();