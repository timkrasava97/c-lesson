/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

 void Z41()
{
Console.WriteLine("Укажите количество вводимых чисел");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;
Console.WriteLine("Введите число");
for(int i = 0; i < size; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if(number > 0) count++;
}
Console.WriteLine($"введено {count} чисел больше нуля");
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Z43()
{
    Console.WriteLine($"Введите значения b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите значения k1");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите значения b2");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите значения k2");
    int k2 = Convert.ToInt32(Console.ReadLine());
    if(k1 == k2)
    {
        Console.WriteLine("нет точки пересечения");
    }

    else
    {
        double x = (b2-b1)/(k1-k2);
        double y = k1 * x + b1;
        double y2 = k2 * x + b2;
        Console.WriteLine($"точки пересечения A({x}, {y})");
        Console.WriteLine($"точки пересечения A({x}, {y2})");
    }

} 


Z41();

Z43();

