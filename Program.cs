﻿// Задача 47. Задайте двумерный массив 
// размером m×n, заполненный случайными 
// вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.Write("Введите колличество строк = ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите колличество столбцов = ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[m, n];

// void GenerateRandomArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-99, 100) / 10.0;
//         }
//     }
// }

// void PrintRandomArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

// GenerateRandomArray(numbers);
// PrintRandomArray(numbers);

// _____________________________________________________________________________________________________


// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [5,5];
// FillArrayRandomNumbers(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("Такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
// }

// PrintArray(numbers);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(-100, 100)/10;
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(""); 
//     }
// }

// _____________________________________________________________________________________________________

// Задача 52. Задайте двумерный массив из 
// целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Write("Введите колличество строк = ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите колличество столбцов = ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[m, n];

// void GenerateRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

// void ArithmeticMean(int[,] array)
// {
//     Console.Write($"Среднее арифметическое каждого столбца: ");
//     for (int j = 0; j < array.GetLength(1); j++)
//     {   
//         double Result = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             Result += array[i, j];
//         }
//         Console.Write($"{Result / array.GetLength(0)}; ");
//     }
// }

// GenerateRandomArray(numbers);
// PrintRandomArray(numbers);
// Console.WriteLine($"");
// ArithmeticMean(numbers);

// ___________________________________________________________________________________________________________________




