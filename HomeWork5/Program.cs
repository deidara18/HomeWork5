//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


int [] array = GetArray(4, 100, 999);


int[] GetArray(int size, int minValue, int maxValue)
  {
    int[] res = new int[size]; 

    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return res;
  }


    int count = 0;
    
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result = array[i];
            count++;
        }          
    }
Console.WriteLine($"первоначальный массив: {String.Join(" ", array)}");
Console.WriteLine($"Количество чётных чисел в массиве = {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// // [3, 7, 23, 12] -> 19

// // [-4, -6, 89, 6] -> 0

int [] array = GetArray(6, 1, 10);

  
Console.WriteLine($"первоначальный массив: {String.Join(" ", array)}");


int summ = 0;
  for (int i = 1; i < array.Length; i+=2)
{
  if (i % 2 != 0){
    summ += array[i];
  }
}


  int[] GetArray(int size, int minValue, int maxValue)
  {
    int[] res = new int[size]; 

    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue); 
    }
    return res;
  }
 Console.WriteLine($"Сумма элементов нечётных позициях  {summ}");




// Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] array = GetArray(10, 1, 10);
//            размерность.   промежуток
Console.WriteLine(String.Join(" ", array)); // Вывод массива через заданный разделитель



int minIndex = array[0];
int maxIndex = 0;
int diffIndex = 0;

  for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxIndex)
    {
        maxIndex = array[i];
    } 
    if (array[i] < minIndex)
    {  
     minIndex = array[i];
    }
     diffIndex = maxIndex - minIndex;   
}
Console.Write($"Максимальный элемент = {maxIndex} Минимальный элемент = {minIndex}  разница между ними = {diffIndex}");

int[] GetArray(int size, int minValue, int maxValue)
  {
    int[] res = new int[size]; 

    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue); 
    }
    return res;
  }

