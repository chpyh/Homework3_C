// ЗАДАЧА 1. Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
/*
int[] FillArray(int size)
{
int[] array = new int[size];
for (int i = 0; i < array.Length; i ++)
{
array[i]= new Random().Next(1, 100);
}
 return array;
}
void PrintArr(int[] numbers)
{
    for(int index = 0; index < numbers.Length; index ++)
    {
    Console.Write(numbers[index] + " ");
    }
    Console.WriteLine();
}
void FindAmmount(int[] collection, int count1, int count2)
{
    int ammount = 0;
    foreach(int element in collection)
    {
        if(element > count1 && element < count2)
        {
              ammount++;
        }
    }
    Console.WriteLine(ammount);
}
int sizeArr = 10;
int[] arr = FillArray(sizeArr);
int count1 = Convert.ToInt32(20);
int count2= Convert.ToInt32(90);
PrintArr(arr);
FindAmmount(arr, count1, count2);
*/

//ЗАДАЧА 2. Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
/* ﻿int[] FillArray(int size)
{
int[] array = new int[size];
for (int i = 0; i < array.Length; i ++)
{
array[i]= new Random().Next(1, 100);
}
 return array;
}
void PrintArr(int[] numbers)
{
    for(int index = 0; index < numbers.Length; index ++)
    {
    Console.Write(numbers[index] + " ");
    }
    Console.WriteLine();
}
void FindAmmount(int[] collection)
{
    int ammount = 0;
    foreach(int element in collection)
    {
        if(element % 2 == 0)
        {
              ammount++;
        }
    }
    Console.WriteLine(ammount);
}
int sizeArr = 10;
int[] arr = FillArray(sizeArr);
PrintArr(arr);
FindAmmount(arr);
*/
//ЗАДАЧА 3. Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] FillArray(int size)
{
double[] array = new double[size];
for (int position = 0; position < array.Length; position ++)
{
int intiger = new Random().Next();
double fraction = new Random().NextDouble();
array[position] = intiger + fraction;
}
 return array;
}
void PrintArr(double[] numbers)
{
    for(int index = 0; index < numbers.Length; index ++)
    {
    Console.Write(numbers[index] + " ");
    }
    Console.WriteLine();
}
double FindMax (double[] arr)
{
    double Max = arr[0];
        for (int count = 0; count < arr.Length; count++)
        {
            if(arr[count] > Max)
            {
                Max = arr[count];
            }
        }
         Console.WriteLine(Max);
        return Max;
    }
double FindMin (double[] coll)
{
    double Min = coll[0];
        for(int serialnumber = 0; serialnumber < coll.Length; serialnumber++)
        {
            if (coll[serialnumber] < Min)
            {
                Min = coll[serialnumber];
            }
        }
         Console.WriteLine(Min);
        return Min;
    }
void FindSubtraction(double minimum, double maximum)
{
   double subtraction = maximum - minimum;
    Console.WriteLine(subtraction);
}
int sizeArr = 10;
double[] collect = FillArray(sizeArr);
PrintArr(collect);
double maxinarr = FindMax(collect);
double mininarr = FindMin(collect);
FindSubtraction(mininarr,maxinarr);
*/

// ЗАДАЧА 4.Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа.
Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Рамер массива равен количеству цифр.
 int[] FillArray(int size, int numero)
{
int[] array = new int[size];
int count = size;
int position = 0;
while(count > 1)
{
    int arraymaker = Convert.ToInt32(Math.Pow(10, count - 1));
    array[position] =  numero/ arraymaker;
    count = count - 1;
    numero = numero - (arraymaker * array[position]);
    position++;
}
array[position] = numero%10;
return array;
}
void PrintArr(int[] numbers)
{
    for(int index = 0; index < numbers.Length; index ++)
    {
    Console.Write(numbers[index] + " ");
    }
    Console.WriteLine();
}
int number = new Random().Next(1, 100000);
Console.WriteLine(number);
int length = number.ToString().Length;
int[] arr = FillArray(length, number);
PrintArr(arr);





















