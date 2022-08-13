

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*

int SumOfElements(int m, int n)
{
    if(m==n)
    {
        return m;
    }
    else
    {
        return m + SumOfElements(m+1,n);
    }
    
}

Console.Write(SumOfElements(1,15));

*/



// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.


int SumOfNums(int num)
{
    if(num/10==0)
    {
        return num;
    }
    else
    {
        return num%10 + SumOfNums(num/10);
    }
}

Console.Write(SumOfNums(4533));