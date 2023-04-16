// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int num1;
while (true)
{
        Console.Write("Введите чило от 100 до 999: ");
        if (int.TryParse(Console.ReadLine(), out num1))
            if (num1 > 99)
                if (num1 < 1000)
                break;
        Console.WriteLine("Ошибка ввода!");
}

int num2 = (num1/10)%10;
Console.WriteLine($"{num1} -> {num2}");