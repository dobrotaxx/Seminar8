/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

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

int[,] FillArraySpiral(int[,] array, int sizeOfArray)
{
    int i = 0;
    int j = 0;
    int count = 1;
    for (int e = 0; e < sizeOfArray * sizeOfArray; e++)
    {
        int k = 0;
        do
        {
            array[i, j++] = count++;
        }
        while (++k < sizeOfArray - 1);
        for (k = 0; k < sizeOfArray - 1; k++)
        {
            array[i++, j] = count++;
        }
        for (k = 0; k < sizeOfArray - 1; k++)
        {
            array[i, j--] = count++;
        }
        for (k = 0; k < sizeOfArray - 1; k++)
        {
            array[i--, j] = count++;
        }
        i++;
        j++;
        sizeOfArray = sizeOfArray < 2 ? 0 : sizeOfArray - 2;
    }
    return array;
}

int size = 4;
int[,] array = new int[size, size];
int[,] generatedSpiralArray = FillArraySpiral(array, size);
ShowArray(generatedSpiralArray);


