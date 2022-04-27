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

// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/* 

Console.Write("Input A number: ");
int aNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Input B number: ");
int bNum = Convert.ToInt32(Console.ReadLine());

int DegreeNum(int a, int b)
{
    int total = a;
    for(int i = 2; i<=b; i++)
    {
        int temp = total*a;
        total = temp;
    }
    return total;
}

Console.WriteLine(DegreeNum(aNum, bNum));

*/

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int NumsSum(int n)
{
    int temp = n/10;
    int digit = 1;
    int sum = 0;
    while(temp!=0)
    {
        temp /= 10;
        digit++;
    }
    
    int temp1 = n;
    for(int i = 0; i<digit; i++)
    {
        int temp2 = temp1%10;
        sum += temp2;
        temp1 = temp1/10;
    }
    return sum;
}

Console.Write(NumsSum(num));

*/

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*

void CreateAndShowArr()
{
    int [] array = new int [8];
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
        Console.Write(array[i] + " ");
    } 
}

CreateAndShowArr();

*/