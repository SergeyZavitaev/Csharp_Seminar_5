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
// Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
bool TestElementFromPosMatrix(int[,] tempMatrix, int posRow, int posCol)
{
    if (posRow-1 > tempMatrix.GetLength(0) || posCol-1 > tempMatrix.GetLength(1))
        return false;
    else
        return true;
}
int[] targetPos = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int[,] array = FillMatrix();
PrintMatrix(array);
if(TestElementFromPosMatrix(array, targetPos[0], targetPos[1])==true){
Console.WriteLine(array[targetPos[0], targetPos[1]]);
}
else{
Console.WriteLine("такого числа в массиве нет");
}