/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

int[,] TurnMatrix(int[,] inputArray)
{
    if (inputArray.GetLength(0) == inputArray.GetLength(1))
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = i + 1; j < inputArray.GetLength(1); j++)
            {
                int buffer = inputArray[j, i];
                inputArray[j, i] = inputArray[i, j];
                inputArray[i, j] = buffer;
            }
        }
    }
    else
    {
        Console.WriteLine("ОШИБКА! Количество строк и столбцов не совпадает. Невозможно перевернуть матрицу");
    }
    return inputArray;
}

int[,] generatedArray = GenerateArray(5, 5, 100);
ShowArray(generatedArray);
int[,] turnedArray = TurnMatrix(generatedArray);
if (generatedArray.GetLength(0) == turnedArray.GetLength(1))
{
    Console.WriteLine();
    ShowArray(turnedArray);
}

