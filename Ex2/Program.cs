Console.Write("Введите число 1: ");
var numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
var numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo)
    Console.WriteLine("Число 1 больше числа 2 ({0} > {1})", numberOne, numberTwo);
else if(numberOne < numberTwo)
    Console.WriteLine("Число 2 больше числа 1 ({1} > {0})", numberOne, numberTwo);
else
    Console.WriteLine("Числа равные!");