//54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void Sort (int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
           {
                 for (int k = 0; k < matrix.GetLength(0) - 1; k++)
            {            
            if (matrix[i,k] < matrix[i,k + 1])
            {
                int Sort = matrix[i, k + 1];
                matrix[i, k + 1] = matrix[i, k];
                matrix[i, k] = Sort;
            }
            
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[0])];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);
Console.WriteLine("Сортировка: ");
Sort(matrix);