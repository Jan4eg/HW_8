/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int m1 = Read("m для первой матрицы");
int n1 = Read("n для первой матрицы (m для второй)");
int n2 = Read("n для второй матрицы");

System.Console.WriteLine();

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

int[,] MultiplicationArray(int[,] Array1, int[,] Array2)
{
    int[,] ArrayResult = new int[Array1.GetLength(0), Array1.GetLength(1)];
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array1.GetLength(1); j++)
        {
            int sum = 0;
            for (int c = 0; c < Array1.GetLength(1); c++)
            {
                sum += Array1[i, c] * Array2[c, j];
            }
            ArrayResult[i, j] = sum;
        }
    }
    return ArrayResult;
   
}

int[,] Array1 = CreateArray(m1, n1);
PrintArray(Array1);

int[,] Array2 = CreateArray(n1, n2);
PrintArray(Array2);

System.Console.WriteLine("Матрица, полученная в результате умножения матриц");

int[,] ArrayResult = MultiplicationArray(Array1, Array2);
PrintArray(ArrayResult);


