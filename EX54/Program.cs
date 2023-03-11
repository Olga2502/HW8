//Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}


void SortDesc(int[,] inArray) 
{
    int temp;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 1;  k < inArray.GetLength(1); k++)
            {
               if (inArray[i, k] > inArray[i, k - 1])
               {
                   temp = inArray[i, k - 1];
                   inArray[i, k - 1] = inArray[i, k];
                   inArray[i, k] = temp;
               }
            }
        }
    }
}     


void PrintArray(int[,] inArray)  
    {
    for (int i = 0; i < inArray.GetLength(0); i++)
        {
        for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j]}\t ");
            }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, -5, 5);
PrintArray(array2D);
Console.WriteLine();

SortDesc(array2D);
PrintArray(array2D);
Console.WriteLine();
