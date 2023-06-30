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
int summaNotEvenNumbers(int[] tempArray)
{
    int sum = 0;
    for (int i = 0; i < tempArray.Length; i++)
        if (i % 2 != 0)
            sum+=tempArray[i];
    return sum;
}

//Задача 36: Задайте одномерный массив,
//заполненный случайными числами.
//Найдите сумму элементов, стоящих
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0
int[] array = RandomFillArray(rand.Next(3, 10), 1, 25);
PrintArray(array);
Console.Write($" -> {summaNotEvenNumbers(array)}");