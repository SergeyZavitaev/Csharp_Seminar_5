//Методы рабочие
Random rand = new Random();

void PrintMatrixDouble(double[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");

        }
        Console.WriteLine();
    }
}

// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double RandomDouble(int minNum = 0, int MaxNum = 10, int NumAfterPoint = 3)
{
    return Math.Round(rand.Next(minNum, MaxNum) + rand.NextDouble(), NumAfterPoint);
}
double[,] FillMatrixDouble(int row = 3, int col = 3,
    int minNum = -10, int maxNum = 10, int NumAfterPoint = 3)
{
    double[,] tempMatrix = new double[row, col];
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
            tempMatrix[i, j] = RandomDouble(minNum, maxNum + 1, NumAfterPoint);
    return tempMatrix;
}

double[,] array = FillMatrixDouble(3, 4, 4, 9);
PrintMatrixDouble(array);
Console.WriteLine();