// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Сделано

// Console.WriteLine("Введите количество строк: ");
// int  rows = Convert.ToInt32(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine()!);

// double[,] array = GetArray(rows, columns);
// PrintArray(array);

// double[,] GetArray(int rows, int columns){
//     double[,] result = new double [rows,columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < columns; j++){
//             result[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;  
//         }
//     }
//         return result;    
// }

// void PrintArray(double[,] Array){
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

//  Сделанно
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2


                                                
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine()!);

// Console.WriteLine("Введите количество строк: ");
// int a = Convert.ToInt32(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int b = Convert.ToInt32(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.WriteLine();
// Console.WriteLine($"Значение элементов на пересечении позиций {a} и {b} = {PosArray(array)}");


// int[,] GetArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] result = new int [rows,columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < columns; j++){
//             result[i, j] = new Random().Next(minValue,maxValue + 1);
//         }
//     }
//         return result;    
// }



// void PrintArray(int[,] Array1){
//     for(int i = 0; i < Array1.GetLength(0); i++){
//         for(int j = 0; j < Array1.GetLength(1); j++){
//             Console.Write($"{Array1[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// int PosArray (int[,] Array2){   
// int result = 0;
//     for (int i = 0; i < Array2.GetLength(0); i++){
//         for (int j = 0; j < Array2.GetLength(1); j++){
//             if (a > rows && b > columns){
//                 Console.WriteLine($"Такого числа нет ");
//             }
//             else{
//                 result = Array2[a, b];   
//             }
//         }
//     }
//     Console.WriteLine();
//     return result;
// }

    
// Сделано
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine()!);

// int[]sum = new int [columns];
// int[,] arr = GetArray(rows, columns, 0, 9);
// PrintArray(arr);

// for (int i = 0; i < columns; i++){
//     for(int j=0; j < rows; j++){
//         sum[i] += arr[j, i];
//     }
// }
// for (int i = 0; i < columns; i++){

//     Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)sum[i]/rows} " );  
// }

// int[,] GetArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] result = new int [rows,columns];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < columns; j++){
//             result[i, j] = new Random().Next(minValue,maxValue + 1);
//         }
//     }
//         return result;    
// }        

// void PrintArray(int[,] Array){
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){

//             Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }