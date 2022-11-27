Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());


// вместо остатка от деления, можно проверить нулевой бит у числа, если он присутствует, то число нечетное
Console.Write("{0} - это число ", number);
Console.WriteLine(((number & 0b1) == 1 ? "нечетное" : "четное"));