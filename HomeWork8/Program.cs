// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();

// void Sort (int[,] arr){
//     for (int i = 0; i < arr.GetLength(0); i++){
//         for (int j = 0; j < arr.GetLength(0); j++){
            

//             } 
//         }
//     }



// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int [m,n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
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

// Сделано
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 5);

// PrintArray(array);
// Console.WriteLine();

// Console.WriteLine($"Наименьшая сумма элементов в строке = {RowSum(array)}");


// int RowSum(int[,] arr){
//     int row = 0;
//     int min = 0;
//     for(int i = 0; i < arr.GetLength(0); i++){
//         min = min + arr[0,i];
//         int sum = 0;
//         for(int j = 0; j < arr.GetLength(1); j++){
//             sum = sum + arr[i, j];  
//         }
//             if(min > sum){
//                 min = sum;
//                 row = i;   
//             }
//     }
//         return row;
// }


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int [m,n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
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


// Сделано
//  Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.WriteLine("Введите количество строк для первой матрици: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов для первой матрици: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество строк для второй матрици: ");
int rows2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов для второй матрици: ");
int columns2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Первая матрица");
int[,] Matrix = GetArray(rows, columns, 0, 5);
PrintArray(Matrix);

Console.WriteLine("Вторая матрица");
int[,] Matrix2 = GetArray(rows2, columns2, 0, 5);
PrintArray(Matrix2);


int[,] resultMatrix = new int[rows,rows2];

MultiplicationMatrix(Matrix, Matrix2, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplicationMatrix(int[,] Matrix, int[,] Matrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++){
    for (int j = 0; j < resultMatrix.GetLength(1); j++){
      int sum = 0;
      for (int k = 0; k < Matrix.GetLength(1); k++){
        sum += Matrix[i,k] * Matrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i, j] = new Random().Next(minValue,maxValue + 1);
        }
    }
        return result;    
}

void PrintArray(int[,] Array){
    for(int i = 0; i < Array.GetLength(0); i++){
        for(int j = 0; j < Array.GetLength(1); j++){
            Console.Write($"{Array[i, j] } ");
        }
        Console.WriteLine();
    }
}

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.WriteLine($"Отсортированный массив: ");
// Sort(array);
// PrintArray(array);

// void Sort(int[,] array){
//   for (int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j < array.GetLength(1); j++){
//       for (int k = 0; k < array.GetLength(1) - 1; k++){
//         if (array[i, k] < array[i, k + 1]){
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int [m,n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().Next(minValue,maxValue + 1);
//         }
//     }
//         return result;    
// }

// void PrintArray(int[,] Array){
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i, j] } ");
//         }
//         Console.WriteLine();
//     }
// }