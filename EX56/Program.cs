// Задайте прямоугольный двумерный массив. Напишите 
//программу, которая будет находить строку с наименьшей суммой элементов.


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

void NumberMinSum(int[,] inArray)
{
    int minRow = 1;
    int minSumRow = 0;
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        minSumRow += inArray[0, i];
    }
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            sum += inArray[i, j];
        }
        if (sum < minSumRow)
        {
            minSumRow = sum;
            minRow = i;
        }
        sum = 0;
    }
    Console.Write($"{minRow + 1} строка c наименьшей суммой элементов ");
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

int[,] array2D = GetArray(row, col, 0, 10);
PrintArray(array2D);
Console.WriteLine();

NumberMinSum(array2D);


