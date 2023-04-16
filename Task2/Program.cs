// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int num = 0;
int num1;
while (true)
{
        Console.Write("Введите чиcло: ");
        if (int.TryParse(Console.ReadLine(), out num1))
            break;
        Console.WriteLine("Ошибка ввода!");
}
if(num1 < 100)
    Console.WriteLine("Третьей цифры нет!");
else 
{
    num = num1/100;
    Console.WriteLine(num);
}