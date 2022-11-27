using System;
using System.Collections;

int[] numbers = new int[3];
Console.Write("Введите число 1: ");
numbers[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
numbers[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
numbers[2] = Convert.ToInt32(Console.ReadLine());

// мы не ищем легких путей :-)
Array.Sort(numbers);

System.Console.WriteLine("Максимальное число - {0}", numbers[2]);