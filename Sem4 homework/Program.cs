int [] CreateRandomArray(int size, int min, int max)
{
    int [] array = new int [size];

    for(int i=0; i<size; i++)
    {
        array [i] = new Random().Next(min, max+1);
    }
    return array;
}

int [] CreateArray(int size)
{
    int [] array = new int [size];

    for(int i=0; i<size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array [i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*

int Search3Num(int [] array)
{
    int count = 0;
    for(int i = 0; i<array.Length;i++)
    {
        if(array[i]%2==0)
        {
            count++;
        }
    }
    return count;
}

int [] myArray = CreateRandomArray(10, 100, 999);
ShowArray(myArray);
Console.Write("Count of the even numbers is " + Search3Num(myArray));

*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*

int OddIndexSum(int [] array)
{
    int sum =0;
    for(int i = 1; i<array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}

int [] myArray = CreateRandomArray(10, 1, 999);
ShowArray(myArray);
Console.Write("Sum of the odd index numbers is " + OddIndexSum(myArray));

*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*

int NumDiff(int [] array)
{
    int min = array[0];
    int max = array[0];
    for(int i = 1; i<array.Length; i++)
    {
        if(array[i]<min)
            min = array[i];
        else if(array[i]>max)
            max = array[i];
    }
    int dif = max - min;
    return dif;
}

int [] myArray = CreateRandomArray(10, -99, 99);
ShowArray(myArray);
Console.Write("Difference between maximum and minimum is " + NumDiff(myArray));

*/
