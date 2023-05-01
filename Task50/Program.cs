/* Напишите программу, которая на 
вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет. */

double[,] matrix = new double[10, 10];

void PrintArray(double[,] matrix, int a, int b)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==a && j==b)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
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
            matrix[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
            if (new Random().NextDouble() > 0.5)
            {
                matrix[i, j] *= -1;
            }

        }
    }
}

int InPutNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int a = InPutNum("Insert x :");
int b = InPutNum("Insert y :");

void OutputElemet(int a, int b)
{
    if (a >= matrix.GetLength(0) || b >= matrix.GetLength(1))
    {
        Console.WriteLine("Oops! You are a fool!");
    }
    else
    {
        Console.WriteLine($"Элемент на позиции (x,y): {matrix[a, b]}");
    }

}
FillArray();
PrintArray(matrix, a, b);
OutputElemet(a, b);
