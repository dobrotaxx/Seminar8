/*
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
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

int[] FindMinInMatrix(int[,] inputMatrix)
{
    int[] coordinate = new int[2];
    int min = inputMatrix[0, 0];
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(0); j++)
        {
            if (inputMatrix[i, j] < min)
            {
                min = inputMatrix[i, j];
                coordinate[0] = i;
                coordinate[1] = j;
            }
        }
    }
    return coordinate;
}

int[,]ResultMatrix(int[,] inputMatrix,int[] coordinate)
{
    int 
}

int uniqValues = 10;
int[,] generatedArray = GenerateArray(5, 5, uniqValues);
ShowArray(generatedArray);


