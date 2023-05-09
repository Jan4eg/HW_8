/*Задача 60. ...Сформируйте трёхмерный массив из случайных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int m = Read("введите m");
int n = Read("введите n");
int c = Read("введите c");

int Read(string arg)
{
    System.Console.WriteLine($"Введите {arg}: ");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int [,,] CreateArray(int m, int n, int c)
{
    int[,,] Array = new int [m, n, c];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int d = 0; d < Array.GetLength(2); d++)
            {
                Array[i, j, d] = new Random().Next(1, 10);
            }
        }
    }
    
    return Array;
}

void PrintArray(int[,,] Array)
{
    string k = "";
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int d = 0; d < Array.GetLength(2); d++)
            {
                k = k + i + j + d;
                System.Console.Write($"{Array[i, j, d]} -{k}- ");
                k = "";
            }
            System.Console.WriteLine(" ");
        }
        //System.Console.WriteLine(" ");
    }
    System.Console.WriteLine();
}

int[,,] Array = CreateArray(m, n, c);
System.Console.WriteLine();
PrintArray(Array);

