//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.


int [,] CreateMatrix(int a, int b)
{
    int [,] matrix = new int [a, b];

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

/*
void AscendingElements(int [,] matrix)
{

    int temp = 0;
   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if(matrix[i,k]>matrix[i,k+1])
                {
                    temp = matrix[i,k];
                    matrix[i,k] = matrix[i,k+1];
                    matrix[i,k+1] = temp;
                }
            }
            
            
        }
    }

    for (int l = 0; l < matrix.GetLength(0); l++)
    {
        for (int h = 0; h < matrix.GetLength(1); h++)
        {
            Console.Write(matrix[l,h] + " ");
        }
        Console.WriteLine();
    }
}

int [,] myMatrix = CreateMatrix(4,4);
Console.WriteLine();
AscendingElements(myMatrix);




int [] myArr = {8,5,4,1,3};

for (int k = 0; k < myArr.Length; k++)
{
    for (int l = 0; l < myArr.Length-1; l++)
    {
        if(myArr[l]>myArr[l+1])
        {
            int temp = myArr[l];
            myArr[l] = myArr[l+1];
            myArr[l+1] = temp;
        }
    }
    
}

for (int i = 0; i < myArr.Length; i++)
{
    Console.Write(myArr[i] + " ");
}

*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/* 

int [,] myMatrix = CreateMatrix(4,3);

int minSumOfElements(int [,] matrix)
{
    int [] sumArray = new int [matrix.GetLength(0)];
    int sum = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        sumArray[i] = sum;
        //Console.Write(sumArray[i]+ "q ");
        sum = 0;
    }
    int minIndex = 0;
    int min = sumArray[0];
    for (int k = 1; k < sumArray.Length; k++)
    {
        if(sumArray[k]<min)
        {
            min = sumArray[k];
            minIndex = k+1;
        }
         
    }
    
    return minIndex;
}

Console.WriteLine();
Console.Write(minSumOfElements(myMatrix) + " string is minimal");

*/ 


// Задача 62. Заполните спирально массив 4 на 4.


int [,] CreateSpiralMatrix(int a, int b)
{
    int [,] matrix = new int [a, b];

    for (int i = 0; i < a; i++)
    {
        if(i==0 || i%3==0)
        {
            for (int j = 0; j < b-1; j++)
            {
                matrix[i,j] = new Random().Next(1,10);
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int j = 0; j < b; j++)
            {
                matrix[i,j] = new Random().Next(1,10);
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
    return matrix;
}

int [,] myMatrix = CreateSpiralMatrix(15,4);