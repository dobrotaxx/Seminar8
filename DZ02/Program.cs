/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int FindingRowWithTheSmallestSumOfElements(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sums[i] += array[i, j];
        }
        Console.WriteLine($"Сумма элементов {i} строки: {sums[i]}");
    }
    int min = 0;
    for (int i = 1; i < sums.Length; i++)
    {
        if (sums[min] > sums[i])
        {
            min = i;
        }
    }
    return min;
}

int[,] generatedArray = GenerateArray(5, 5, 20);
ShowArray(generatedArray);
int result = FindingRowWithTheSmallestSumOfElements(generatedArray);
Console.WriteLine($"{result} строка является строкой с наименьшей суммой");
