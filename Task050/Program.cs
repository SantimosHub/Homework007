// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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


int FindElement(int[,] forArray, int forPosition)
{
    int count = 0;
    int result = 0;
    do
    {
        for (int i = 0; i < forArray.GetLength(0); i++)
        {
            for (int j = 0; j < forArray.GetLength(1); j++)
            {
                count++;
                result = forArray[i, j];
            }
        }
    }
    while (count == forPosition);
    return result;
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);
Console.WriteLine();

Console.Write("Введитe номер позиции элемента: ");
int position = Convert.ToInt32(Console.ReadLine());


if (position > rows * columns || position <= 0) Console.WriteLine("Элемента с таким порядковым номером в массиве нет");
else Console.Write($"Элемент под номером {position} это {FindElement(array, position)}");