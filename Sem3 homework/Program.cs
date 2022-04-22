// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*

Console.Write("Input five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num<10000 || num>99999)
{
    Console.Write("Incorrect number");
}

void Palidrom()
{
    int firstN = num/10000;
    int secondN = num/1000 - firstN*10;
    int thirdN = num/100 - firstN*100 - secondN*10;
    int forthN = (num%100)/10;
    int fifthN = num%10;
    int left = thirdN*100 + secondN*10 + firstN;
    int right = thirdN*100 + forthN*10 + fifthN;

    if(left == right)
    {
        Console.WriteLine("Your number is palidrom");
    }
    else
    {
        Console.WriteLine("Your number is NOT palidrom");
    }
}
Console.Write(num + " -> ");
Palidrom();

*/


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

Console.Write("Input X1 coordinate: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y1 coordinate: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z1 coordinate: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input X2 coordinate: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y2 coordinate: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z2 coordinate: ");
double z2 = Convert.ToDouble(Console.ReadLine());

void DotRange()
{
    double r = ((x2-x1)*(x2-x1)) + ((y2-y1)*(y2-y1)) + ((z2-z1)*(z2-z1));
    Console.WriteLine("Distance between dots = " + Math.Sqrt(r));
}

DotRange();

*/



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

void Cube()
{
    int current = 1;
    Console.Write(num + " -> ");
    while(current<=num)
    {
        int cubeNum = current*current*current;
        current++;
        Console.Write(cubeNum + " ");
    }
}
Cube();

*/

