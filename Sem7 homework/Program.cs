
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
Console.Write("Input first matrix index: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second matrix index: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] CreateMatrix(int a, int b)
{
    double [,] matrix = new double [a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble() * 40 - 20, 1);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}

double [,] myMatrix = CreateMatrix(m, n);

*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


/*

Console.Write("Input first matrix position: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second matrix position: ");
int second = Convert.ToInt32(Console.ReadLine());

int a = 3;
int b =5;

int [,] CreateMatrix(int size1, int size2)
{
    int [,] matrix = new int [a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matrix[i,j] = new Random().Next(1,10);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}

int [,] myMatrix = CreateMatrix(a,b); 
Console.WriteLine();

void FindElement(int firstpos, int secondpos)
{
    if (firstpos>a || secondpos>b)
    {
        Console.WriteLine("This position is outside");
    }
    else
    {
        Console.WriteLine(myMatrix[firstpos, secondpos]);
    }
}

FindElement(first,second);

*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void CreateMatrix(int a, int b)
{
    int [,] matrix = new int [a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matrix[i,j] = new Random().Next(1,10);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    double avarage = 0;
    for (int j = 0; j < b; j++)
    {
        for (int i = 0; i < a; i++)
        {
            avarage += matrix[i,j];
        }
        Console.Write(Math.Round(avarage/a, 1) + "; ");
        avarage = 0;
    }

}

CreateMatrix(3,5);

