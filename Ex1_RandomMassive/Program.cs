// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int GetNumberByUser()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateArray(int size1, int size2)
{
    return new double[size1, size2];
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next();
        }
    }
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int number1 = GetNumberByUser();
int number2 = GetNumberByUser();
double[,] result = CreateArray(number1, number2);
FillArray(result);
Console.WriteLine();
Console.WriteLine("Случайный двумерный массив:");
PrintArray(result);

