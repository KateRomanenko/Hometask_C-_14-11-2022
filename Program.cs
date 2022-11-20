// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

/*
Console.Write("Введите числа через запятую (без пробела): ");
string str = Console.ReadLine();
int[] mass = str.Split(',').Select(int.Parse).ToArray();

for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + ", ");
} 

int count = 0; 
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        count++;
    }
}
Console.Write("Количество чисел больше нуля: ");
Console.WriteLine(count);
*/


// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
Console.WriteLine("введите значение b1");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("введите значение k1");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("введите значение b2");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("введите значение k2");
double k2 = double.Parse(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y = k1*x + b1;

Console.WriteLine(x + " ; " + y);
*/

//////////// Исправление ошибок ДЗ 5

//  Задайте массив заполненный случайными положительными 
//  трёхзначными числами. Напишите программу, 
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
void Print(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
}

int[]mass = new int[4];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100,999);
}
Print(mass);

int count = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (mass [i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);
*/

// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
void Print(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
}

int[]mass = new int[4];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-100,100);
}
Print(mass);

int sum = 0;

for (int i = 1; i < mass.Length; i+=2)
{
   sum+= mass[i];
}
Console.WriteLine(sum);
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

void Print(double[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
}

double []mass = new double[4];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 10) + new Random().NextDouble();
}

Print(mass);

double max = 0;
double min = 1;
double diff = 0;


for (int i = 0; i < mass.Length; i++)
{
    if(mass[i] > max)
    {
        max = mass[i];
        mass[i]++;
    }
    else if (mass[i] < min)
    {
        min = mass[i];
        mass[i]++;
    }
    diff = max-min;
}

Console.WriteLine($"Максимальное число: {max}. Минимальное число: {min}. Разница: {diff}");


