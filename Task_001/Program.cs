// Задача № 2 семинара. Напишите программу, которая принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{ 
    Console.WriteLine(number1 + "- большее");
    Console.WriteLine(number2 + "- меньшее"); 
    } 
    else
    { 
        Console.WriteLine(number2 + "- большее");
        Console.WriteLine(number1 + "- меньшее");
    }