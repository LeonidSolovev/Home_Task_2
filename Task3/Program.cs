// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int num1;
while (true)
{
        Console.Write("Введите чиcло от 1 до 7: ");
        if (int.TryParse(Console.ReadLine(), out num1))
            if (num1 > 0)
                if (num1 < 8)
                    break;
        Console.WriteLine("Ошибка ввода!");
}

if (num1 < 6) Console.WriteLine($"{num1} -> нет");
else if (num1 > 5) Console.WriteLine($"{num1} -> да");