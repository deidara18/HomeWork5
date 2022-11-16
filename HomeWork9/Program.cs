// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

 Console.WriteLine(PrintNumbers(N, 1));

 string PrintNumbers(int start, int end){
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
 }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число M");
// int M = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число N");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(M));

// int PrintNumbers (int M){
//     if (N <= M) return M;
//     return M  + PrintNumbers(M + 1);
// }



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Console.WriteLine("Введите число m");
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число n");
// int m = int.Parse(Console.ReadLine()!);


// Console.WriteLine(Akkerman(n, m));

// int Akkerman (int n, int m){
//         if (n == 0) return m + 1;
//         if (n != 0 && m == 0) return Akkerman(n - 1, 1);
//         if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
//         return Akkerman(n,m);
   
// }