/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
//===================== task 1 ===============================
int[,] CreateRandom2DArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void Show2DArray(int[,] array)
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

// int[,] SortRowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = 0;
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     temp = array[i, k];
//                     array[i, k] = array[i, k + 1];
//                     array[i, k + 1] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// int rows = 5;
// int cols = 4;
// int min = 1;
// int max = 15;
// int[,] array = CreateRandom2DArray(rows, cols, min, max);
// Show2DArray(array);
// Console.WriteLine();
// int[,] sortedArray = SortRowArray(array);
// Show2DArray(sortedArray);


/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

//===================== task 2 ===============================
// int FindArrayRowWithMinSum(int[,] array)
// {
//     int rowWithMinSum = 0;
//     int[] rowArray = new int[array.GetLength(0)];
//     Console.WriteLine("rows= " + array.GetLength(0));
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             rowArray[i] += array[i, j];
//         }
//         Console.WriteLine(rowArray[i]);
//     }

//     rowWithMinSum = rowArray[0];
//     for (int i = 1; i < rowArray.Length; i++)
//     {
//         if (rowWithMinSum > rowArray[i]) rowWithMinSum = rowArray[i];
//     }
//     return rowWithMinSum;
// }

// int rows = 5;
// int cols = 4;
// int min = 1;
// int max = 15;
// int[,] array = CreateRandom2DArray(rows, cols, min, max);
// Show2DArray(array);
// Console.WriteLine();
// int num = FindArrayRowWithMinSum(array);
// Console.WriteLine();
// Console.WriteLine(num);

/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

//===================== task 3 ===============================
int[,] Multiply2DArray(int[,] array1, int[,] array2)
{
    int[,] multiArray = new int[array1.GetLength(0), array1.GetLength(1)];
    if(array1.GetLength(0)!=array1.GetLength(1) ||
       array1.GetLength(0)!=array2.GetLength(0) || 
       array1.GetLength(1)!=array2.GetLength(1)) Console.WriteLine("The sizes of array aree not correctted");
       else {
        for (int i = 0; i < multiArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiArray.GetLength(1); j++)
            {
                multiArray[i,j] = array1[i,0] * array2[0,j];
                for (int k = 1; k < multiArray.GetLength(1); k++)
                {
                    multiArray[i,j] += array1[i,k]*array2[k,j];
                }
            }
        }
       }
       return multiArray;
}

Console.Write("Enter row's number of array 1: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column's number of array 1: ");
int cols1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter row's number of array 1: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column's number of array 1: ");
int cols2 = Convert.ToInt32(Console.ReadLine());

int min = 1;
int max = 9;

int[,] array1 = CreateRandom2DArray(rows1, cols1, min, max);
int[,] array2 = CreateRandom2DArray(rows2, cols2, min, max);

int[,] multy2DArray = Multiply2DArray(array1, array2);
Show2DArray(array1);
Console.WriteLine();
Show2DArray(array2);
Console.WriteLine();
Show2DArray(multy2DArray);

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
 двузначных чисел. Напишите программу, которая будет построчно
  выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

//===================== task 4 ===============================


/*
Задача 62. Напишите программу, которая заполнит спирально 
массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/