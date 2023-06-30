//Методы рабочие
Random rand = new Random();

void PrintMatrix(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
            Console.Write(table[i, j] + "\t");
        Console.WriteLine();
    }
}
int[,] FillMatrix(int row = 3, int col = 3, int minNum = -10, int maxNum = 10)
{
    int[,] tempMatrix = new int[row, col];
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
            tempMatrix[i, j] = rand.Next(minNum, maxNum + 1);
    return tempMatrix;
}
void PrintArrayDouble(double[] tempArray)
{
    Console.Write("[" + string.Join(", ", tempArray) + "]");
}
// Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
double[] AverageEveryColumn(int[,] tempMatrix)
{
    double[] AverageMassive = new double[tempMatrix.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < tempMatrix.GetLength(1); j++) //col
    {
        sum = 0;
        for (int i = 0; i < tempMatrix.GetLength(0); i++) //row
        {
            sum += Convert.ToDouble(tempMatrix[i, j]);
        }
        AverageMassive[j] = (Math.Truncate((sum/tempMatrix.GetLength(0))*10))/10;
    }
    return AverageMassive;
}

int[,] array = FillMatrix(3, 4, 1, 10);
PrintMatrix(array);
PrintArrayDouble(AverageEveryColumn(array));