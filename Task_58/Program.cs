// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] firstMatrix = new int[result, result];
int[,] secondMatrix = new int[result, result];
int[,] resultMatrix = new int[result, result];

void GetArray(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            firstMatrix[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

GetArray(firstMatrix);
GetArray(secondMatrix);

PrintArray2D(firstMatrix);
Console.WriteLine();

PrintArray2D(secondMatrix);
Console.WriteLine();

for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
}

PrintArray2D(resultMatrix);