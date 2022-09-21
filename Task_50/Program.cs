/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4*/

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 99);
        }
    }
}



void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("Введите количество строк (lines)");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (columns)");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[3, 4];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

if (lines > numbers.GetLength(0) || columns > numbers.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
else
    {
        Console.WriteLine($"значение элемента строки {lines} и столбца {columns} равно {numbers[lines-1,columns-1]}");
    }

