// Задача 13: Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

void validate()
{
    int num = Prompt("Введите число");
    if (num < 100)
    {
        Console.WriteLine("Третьей цыфры нет");
    }
    else
    {
        while (num > 1000)
        {
            num /= 10;
        }
        
        Console.WriteLine($"-> {num % 10}");

    }

}

validate();

