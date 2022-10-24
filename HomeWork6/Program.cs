
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите количесвто чисел M на проверку");
int M = Convert.ToInt32(Console.ReadLine()!);
    int count = 0;
    for (int i =0; i< M; i++)
    {
        Console.WriteLine("Введите числа на проверку");
        int numebr = Convert.ToInt32(Console.ReadLine()!);
        if (numebr > 0)
        count++;
    }
    Console.WriteLine($"Чисел больше 0 = {count}");
    



// Сделано
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

  
// Console.WriteLine("Введите b1");
// double b1 = Convert.ToDouble(Console.ReadLine()!);
// Console.WriteLine("Введите k1");
// double k1 = Convert.ToDouble(Console.ReadLine()!);
// Console.WriteLine("Введите b2");
// double b2 = Convert.ToDouble(Console.ReadLine()!);
// Console.WriteLine("Введите k2");
// double k2 = Convert.ToDouble(Console.ReadLine()!); 


// Формула для нахождения персечений двух прямых
// y = k1 * x + b1, y = k2 * x + b2                                                   
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1)/(k1 - k2)
// y = k1 * x + b1


// double x = (b2 - b1)/(k1 - k2);         
// double y = k1 * x + b1;

// Console.WriteLine($"Пересечение двух прямых будет в точке {x};{y}");



   








