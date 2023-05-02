/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] matrix = new int[10, 10];

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],8}  ");
        }
        Console.WriteLine();
    }
}

void FillArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100);
        }
    }
}

double[] SumColums(int[,] matrix)
{
    double[] ColumnSums = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double Sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum += matrix[j, i];
        }
        ColumnSums[i] = Sum;
    }
    return ColumnSums;
}

void PrintAverages(double[] Sums)
{
    for (int i = 0; i < Sums.GetLength(0); i++)
    {
        double a = Sums[i]/matrix.GetLength(1);
       
        Console.Write("   " + a);    
    }

}

FillArray();
PrintArray(matrix);
double[] c = SumColums(matrix);
Console.WriteLine("Среднее арифметическое столбцов:");
PrintAverages(c);

