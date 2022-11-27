
// Вариант с перебором в отрицательную сторону
Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());


if (number > 0)
    for(int i = 1; i <= number; i++){
    if(i%2 == 0)
        Console.WriteLine(i);
}
else
{
    for(int i = 1; i >= number; i--){
    if(i%2 == 0)
        Console.WriteLine(i);
}
}

/*
// Обычный вариант
Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());


for(int i = 1; i <= number; i++){
    if(i%2 == 0)
        Console.WriteLine(i);
}
*/