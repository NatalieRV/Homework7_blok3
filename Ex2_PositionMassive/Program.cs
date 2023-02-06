// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

Console.WriteLine("Создайте двумерный массив");
int number1 = GetNumberByUser();
int number2 = GetNumberByUser();
int[,] array = CreateArray(number1, number2);
Console.WriteLine();
FillArray(array);
Console.WriteLine();

Console.WriteLine("Введите позицию в массиве");
Console.Write("Позиция1 = ");
int position1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Позиция2 = ");
int position2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if ((position1 < array.GetLength(0)) && (position2 < array.GetLength(1)))
{
    Console.WriteLine($"Элемент массива ({position1},{position2}) = {array[position1, position2]}");
}
else
{
    Console.WriteLine("Нет такого элемента");
}



