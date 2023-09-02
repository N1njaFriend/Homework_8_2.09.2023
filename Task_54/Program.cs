// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
bool isValidInput1 = false;
int result1 = 0;

do
{
    Console.Write("Введите размерность: ");
    isValidInput1 = int.TryParse(Console.ReadLine(), out result1);

    if (!isValidInput1)
    {
        Console.WriteLine("Пожалуйста, введите число.");
    }
} while (!isValidInput1);

bool isValidInput2 = false;
int result2 = 0;

do
{
    Console.Write("Введите размерность: ");
    isValidInput2 = int.TryParse(Console.ReadLine(), out result2);

    if (!isValidInput2)
    {
        Console.WriteLine("Пожалуйста, введите число.");
    }
} while (!isValidInput2);

int[,] matrix = new int[result1,result2];

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

void PrintArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

GetArray();
PrintArray();
SortArray(matrix);
System.Console.WriteLine();
PrintArray();