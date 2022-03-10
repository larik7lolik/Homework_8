// Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.
Console.Clear();
int[,] array = new int[4, 4];
Random number = new Random();

Console.WriteLine("Дан массив:");
FillArray();
PrintArray();
Sum();

void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = number.Next(1, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void Sum()
{
    int value = 0;
    int sumStr = 0;
    int minSumStr = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumStr = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumStr = sumStr + array[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sumStr}");
        if (i == 0)
        {
            value = sumStr;
        }
        else
        {
            if (sumStr < value)
            {
                value = sumStr;
                minSumStr = i + 1;
            }
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой всех элементов: {minSumStr}");
}
