//Методы рабочие
Random rand = new Random();
double RandomDouble(int minNum = 0, int MaxNum = 10, int NumAfterPoint = 3)
{
    return Math.Round(rand.Next(minNum, MaxNum) + rand.NextDouble(), NumAfterPoint);
}
double[] FillDoubleArray(int count = 10, int minNum = -9, int maxNum = 9, int NumAfterPoint = 3)
{
    double[] tempArray = new double[count];
    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = RandomDouble(minNum, maxNum + 1, NumAfterPoint);
    return tempArray;
}
void PrintDoubleArray(double[] tempArray)
{
    Console.Write("[" + string.Join(", ", tempArray) + "]");
}

//Метод для домашнего задания
double difMaxAndMinInArray(double[] TempArray)
{
    //max
    double max = TempArray[0];
    for (int i = 0; i < TempArray.Length; i++)
        if (TempArray[i] > max)
            max = TempArray[i];
    //min
    double min = TempArray[0];
    for (int i = 0; i < TempArray.Length; i++)
        if (TempArray[i] < max)
            min = TempArray[i];
    return max-min;
}

//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и
//минимальным элементов массива.
//[3 7 22 2 78] -> 76
double[] array = FillDoubleArray(rand.Next(3, 7), 1, 100);
PrintDoubleArray(array);
Console.Write($" -> {difMaxAndMinInArray(array)}");