/*

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


System.Console.WriteLine("Введите число N: ");
var str = Console.ReadLine() ?? "";

int number = int.Parse(str);

string ResultNum(int num)
{
    if (num == 1)
    {
        return num.ToString();
    }
    else 
    {
        return num  + ", " + ResultNum(num - 1);
    }
}

System.Console.WriteLine(ResultNum(number));
