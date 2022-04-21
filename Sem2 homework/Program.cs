// Задача 10
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

/*
Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num<100 || num>1000)
    Console.Write("Error! Input corect number!");

void SecondNum()
{
    int cut1 = num % 100;
    int cut2 = cut1 / 10;
    Console.WriteLine(cut2);
}
SecondNum();
*/


// Задача 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


/*
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

void ThirdNum()
{
    if(num<100)
    {
        Console.Write("Your number does not have a third digit");
    }
    else if(num>99 && num<1000)
    {
        int cutNum = num % 10;
        Console.Write(num + " -> " + cutNum);
    }
    else if(num>999 && num<10000)
    {
        int cutNum = num % 100;
        int cutNum2 = cutNum / 10;
        Console.Write(num + " -> " + cutNum2);
    }
    else if(num>9999 && num<100000)
    {
        int cutNum = num % 1000;
        int cutNum2 = cutNum / 100;
        Console.Write(num + " -> " + cutNum2); 
    }
}
ThirdNum();

*/

// Задача 15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

/*

Console.Write("Input number from 1 to 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num<1 || num>7)
    Console.Write("Incorrect number!");

void DayNum()
{
    if(num == 6 || num == 7)
    {
       Console.Write("Hooray! Today is a day off"); 
    }
    else if(num>0 && num<6)
    {
        Console.Write("Today is a weekday"); 
    }
}
DayNum();

*/