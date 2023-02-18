// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

void Validate()
{
    int num = Prompt("Введите цифру дня недели ");
    if (num > 0 && num < 8)
    {
        if (num == 6 || num == 7)
        {
            Console.WriteLine("Это выходной");
        }
        else
        {
            Console.WriteLine("Это рабочий день");
        }
    }
    else
    {
        Console.WriteLine("Такого дня недели нет");
    }
}

Validate();