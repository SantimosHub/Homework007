// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


double[] GetSumOfCollumns(int[,] forArray, int forRows, int forColumns)
{
    double[] resArray = new double[forColumns];

    for (int j = 0; j < forArray.GetLength(1); j++)
    {
        for (int i = 0; i < forArray.GetLength(0); i++)
        {
            resArray[j] += forArray[i, j];
        }
        resArray[j] = Math.Round(resArray [j] / forRows, 1);
    }
    return resArray;
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);

double[] sumOfColumn = GetSumOfCollumns(array, rows, columns);

Console.WriteLine();
Console.WriteLine(String.Join(" ", sumOfColumn));