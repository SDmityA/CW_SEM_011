// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// *************Задача 1***************************
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] array = new int[12];
// int sum = 0;
// int sum2 = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(-9,10);
//     if (array[i]>0)
//     {
//         sum=sum+array[i];
//     }
//     else sum2=sum2+array[i];
// }
// Console.WriteLine("Массив: " + String.Join(",",array));
// Console.WriteLine("Положительные: "+ sum + "  " + "Отрицательные: " + sum2);

// **********************Конец************************************
// *************************Задача 2********************************
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int [] array = {-4, -8, 8, 2};
// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=-array[i];
// }
// Console.WriteLine(String.Join(",",array));

// ********************конец*********************
// ****************Задача 3**********************

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Введите число");
// int num= int.Parse(Console.ReadLine());
// int [] array = {-4,-8,8,-16,0,2};
// bool res = false;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == num)
//     {
//         res=true;
//     }
    
// }
// if (res==true)
// {
//     Console.WriteLine("ДА");
// } else Console.WriteLine("Нет");

// *********************Конец*******************
// ********************Задача 4*********************
// ЗЗадайте одномерный массив из 5 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int [] array = new int[5]; 
// int num =0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-100,101);
//     Console.Write(array[i]+",");

//     if (array[i]>=10 && array[i]< 100)
//     {
//         num=num+1;
//     }
// }
// Console.WriteLine();
// Console.WriteLine(num);

// ***************************Конец***********************
// ***********************Задача 5************************
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Console.WriteLine("Введите длинну массива");
// int num= int.Parse(Console.ReadLine());

// int [] array1=new int [num];
// int [] array2= new int[(num/2)+(num%2)];

// for (int i = 0; i < array1.Length; i++)
// {
//     array1[i]= new Random().Next(0,11);
// }
// for (int j = 0; j < array2.Length; j++)
// {
//     array2[j]=array1[j]*array1[num-j-1];

//     if (j==num-1-j)
//     {
//         array2[j]=array1[j];
//     }

// }
// Console.WriteLine(String.Join(",",array1));
// Console.WriteLine();
// Console.WriteLine(String.Join(",", array2));

// ***************************Конец*********************



