// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array3D = new int[2, 2, 2];

void FillArray(int[,,] array)

// счетчик с фиксировнными числами

// {
//     int count = 10;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] += count;
//                 count += 1;
//             }
//         }
//     }
// }

// массив случайных двухзначных неповторяющихся чисел

{
    Random random = new Random();
    List<int> numbers = new List<int>();

    for (int i = 10; i <= 101; i++)
    {
        numbers.Add(i);
    }

    for (int i = numbers.Count - 1; i > 0; i--)
    {
        int j = random.Next(i + 1);
        int temp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = temp;
    }

    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = numbers[index];
                index++;
            }
        }
    }
}


void PrintIndex(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]:D2}({i},{j},{k}) ");
            }
        }
    }
}

FillArray(array3D);
PrintIndex(array3D);