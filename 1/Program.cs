/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


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

int[,] Descending(int[,] Array)
{
    int temp = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int c = 0; c < Array.GetLength(1)-1; c++)
            {
                if (Array[i, c] < Array[i, c + 1])
                {
                temp = Array[i, c + 1];
                Array[i, c + 1] = Array[i, c];
                Array[i, c] = temp;
                }
            }
               
        }
    }
    return Array;
}



int[,] Array = CreateArray(m, n);
PrintArray(Array);
Descending(Array);
PrintArray(Array);

