// Task 1
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input number one: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number two: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    Console.Write("Number one is more than number two: max = " + num1);
else
    Console.Write("Number two is more than number one: max = " + num2);

*/


// Task 2
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input number one: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number two: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number three: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)
    max = num2;
if(num3 > max)
    max = num3;

Console.Write("Max number = " + max);

*/

// Task 3
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

//int result = num / 2;
if(num % 2 == 0)
    Console.WriteLine("This number is even");
else
    Console.WriteLine("This number is odd");

*/

// Task 4
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;

if(num < 0)
    num = num * (-1);

while (current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}

*/
