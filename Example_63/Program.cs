// Задача 63: Сформировать трёхмерный массив с не повторяющимися двузначными числами и вывести его на экран построчно, с индексами элементов.
int[,,] massiv = new int[3, 4, 5];
int count = 10;
void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] = count;
                count++;
            }
        }
    }

}
void PrintMassiv(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("Page №: " + (i + 1));

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
                Console.Write($"{array[i, j, z]} [{i}, {j}, {z}] ");
        Console.WriteLine();
        }
        Console.WriteLine("=====================");
    }
}
FillArray(massiv);
PrintMassiv(massiv);
