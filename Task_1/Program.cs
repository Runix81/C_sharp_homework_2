// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int Prompt(string message)                          //
{                                                   //
    Console.Write($"{message} -> ");                // метод ввода числа 
    return Convert.ToInt32(Console.ReadLine());     //
}                                                   //

int validate(int num)                                   // 
{                                                       //
    while (num < 100 || num > 999)                      //
    {                                                   //
        Console.WriteLine("Это не трехзначное число");  //    метод проверки числа
        num = Prompt("Введите трехзначное число");      //
    }                                                   //
    return num / 10 % 10;                               //
}                                                       //

int number = Prompt("Введите трехзначное число"); // вводим число 

Console.WriteLine($"Второе число равно: {validate(number)}"); // выводим результат


