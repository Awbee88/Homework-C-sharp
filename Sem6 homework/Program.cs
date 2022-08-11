//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//

/*

Console.Write("How many numbers do you want to enter ");
int num = Convert.ToInt32(Console.ReadLine());

int HowManyZero(int a)
{
    int [] array = new int [a];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-101, 101);
        Console.Write(array[i] + " ");
    }

    int zero = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j]>0)
        {
            zero +=1;
        }
    }
    return zero;
}

Console.WriteLine("-> " + HowManyZero(num));

*/


//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

string boolNum = string.Empty;

while(num>0)
{
    boolNum = (num%2) + boolNum;
    num/=2;
}

Console.WriteLine(boolNum);




//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.