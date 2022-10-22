/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] GenerateArray(int height, int width, int deviation)
{
    int[,] generatedArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            generatedArray[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return generatedArray;
}

void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void ShowArray(int[,] inputArray)
{
    PrintColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        PrintColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        PrintColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] FindingProductOfMatrices(int[,] array, int[,] secondArray)
{
    int[,] theProductOfMatrices = new int[array.GetLength(1), secondArray.GetLength(0)];
    if (array.GetLength(1) == secondArray.GetLength(0))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                int temp = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    temp += array[i, k] * secondArray[k, j];
                }
                theProductOfMatrices[i, j] = temp;
            }
        }
    }
    else
    {
        Console.WriteLine($"Невозможно выполнить произведение матриц");
    }
    return theProductOfMatrices;
}

int[,] generatedArray = GenerateArray(2, 2, 3);
int[,] generatedSecondArray = GenerateArray(2, 2, 3);
Console.WriteLine($"Матрица №1: ");
ShowArray(generatedArray);
Console.WriteLine($"Матрица №2: ");
ShowArray(generatedSecondArray);
int[,] result = FindingProductOfMatrices(generatedArray, generatedSecondArray);
Console.WriteLine($"Результат произведения матриц: ");
ShowArray(result);
