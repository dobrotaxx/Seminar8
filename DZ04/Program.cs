/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] Generate3DArray(int depth, int height, int width, int start, int end)
{
    int[,,] generatedArray = new int[depth, height, width];
    for (int z = 0; z < depth; z++)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                generatedArray[z, i, j] = new Random().Next(start, end + 1);
            }
        }
    }
    return generatedArray;
}

void Show3DArryLikeARow(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

int[,,] generated3DArray = Generate3DArray(2, 2, 2, 10,99);
Show3DArryLikeARow(generated3DArray);
