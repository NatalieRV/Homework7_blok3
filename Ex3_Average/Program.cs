// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int GetNumberByUser()
{
    Console.Write("Введите размерность: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int size1, int size2)
{
    return new int[size1, size2];
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"Введите элемент массива ({i}, {j}) = ");
            matr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

void AverageColumn(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double summa = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            summa = summa + matr[i, j];
        }
        double average = summa / matr.GetLength(0);
        average = Math.Round(average, 2);
        Console.WriteLine($"Среднее {j + 1} столбца = {average}");
    }
}

Console.WriteLine("Создайте двумерный массив");
int number1 = GetNumberByUser();
int number2 = GetNumberByUser();
int[,] array = CreateArray(number1, number2);
Console.WriteLine();
FillArray(array);
Console.WriteLine();
AverageColumn(array);
