//Методы рабочие
Random rand = new Random();
int[] RandomFillArray(int count = 10, int leftRange = -9, int rightRange = 9)
{
    int[] tempArray = new int[count];
    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    return tempArray;
}
void PrintArray(int[] tempArray)
{
    Console.Write("[" + string.Join(", ", tempArray) + "]");
}

//Метод для домашнего задания
int countEvenNumbers(int[] tempArray)
{
    int result = 0;
    for (int i = 0; i < tempArray.Length; i++)
        if (tempArray[i] % 2==0)
            result++;
    return result;
}

//Задача 34: Задайте массив заполненный
//случайными положительными трёхзначными
//числами. Напишите программу, которая
//покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] array = RandomFillArray(rand.Next(3, 10), 1, 999);
PrintArray(array);
Console.Write($" -> {countEvenNumbers(array)}");