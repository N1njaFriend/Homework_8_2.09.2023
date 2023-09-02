// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int numMartrix = 4;
int[,] spiraleMatrix = new int[numMartrix, numMartrix];

int k = 1;
int i = 0;
int j = 0;

while (k <= numMartrix * numMartrix)
{
    spiraleMatrix[i, j] = k;
    if (i <= j + 1 && i + j < numMartrix - 1)
        ++j;
    else if (i < j && i + j >= numMartrix - 1)
        ++i;
    else if (i >= j && i + j > numMartrix - 1)
        --j;
    else
        --i;
    ++k;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString("D2") + " ");
        }
        Console.WriteLine("");
    }
}

PrintArray(spiraleMatrix);