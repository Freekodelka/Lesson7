/* /*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double [,] matrix = new double [10,10];

void PrintArray (double [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]}  ");
    }
    Console.WriteLine();
}
}

void FillArray ()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble() * 100, 2);
            if (new Random().NextDouble() > 0.5) 
            {
                matrix[i,j] *= -1;
            }
            
        }
    }
}

FillArray();
PrintArray(matrix); 

