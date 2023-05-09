/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


int m = Read("введите m");
int n = Read("введите n");

int Read(string arg)
{
    System.Console.WriteLine($"Введите {arg}: ");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int [,] CreateArray(int m, int n)
{
    int[,] Array = new int [m, n];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(1, 10);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write($"{Array[i, j]} ");
            System.Console.Write(" ");
        }
        System.Console.WriteLine(" ");
    }
    System.Console.WriteLine(" ");
}

int[] Descending(int[,] Array)
{
    int [] sumArray = new int[Array.GetLength(0)];

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (j < Array.GetLength(1)-1)
            {
                sum += Array[i, j];
            }
            if (j == Array.GetLength(1)-1)
            {
                sum += Array[i, j];
                //System.Console.WriteLine($"Сумма {i+1} строки = {sum}");
                sumArray[i] = sum;
            }
        }
    }
    return sumArray;
}

void FindeSmallSum(int[] array)
{
    int minSum = array[0];
    int str = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSum) 
        {
            minSum = array[i];
            str = i+1;
        }
        
    }
    System.Console.WriteLine($"Минимальная сумма: {minSum}, строка: {str} ");
}

int[,] Array = CreateArray(m, n);
PrintArray(Array);
int[] sumArray = Descending(Array);
FindeSmallSum(sumArray);
