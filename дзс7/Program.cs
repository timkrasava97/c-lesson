// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void Z47()
{
  Console.Write("Введите m: ");
  int m = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите n: ");
  int n = Convert.ToInt32(Console.ReadLine());

  Console.Clear();
  Console.WriteLine($"m = {m}, n = {n}.");

  double[,] array = new double[m, n];

  CreateArrayDouble(array, m, n);
  WriteArray(array, m, n);

  Console.WriteLine();
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

void Z50()
{
  Console.Write("Введите координату X ");
  int x = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите координату Y ");
  int y = Convert.ToInt32(Console.ReadLine());
  int m = 7;
  int n = 7;

  Console.WriteLine($"m = {m}, n = {n}.");

  int[,] array = new int[m, n];
  CreateArrayInt(array, m, n);
  WriteArrayInt(array, m, n);
  if(x <= m && y <= n && x >= 0 && y >= 0 )
  {
    int result = array[x - 1  , y -1 ];
    Console.WriteLine(result + " значение");
  }
  else Console.Write($"такого элемента в массиве нет.");
}

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Z52()
{
  Console.Write("Введите m: ");
  int m = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите n: ");
  int n = Convert.ToInt32(Console.ReadLine());

  int[,] array = new int[m, n];

  CreateArrayInt(array, m, n);
  WriteArrayInt(array, m, n);

  for (int i = 0; i < n; i++)
  {
    double arithmeticMean = 0;
    for (int j = 0; j < m; j++)
    {
      arithmeticMean += array[j, i];
    }
    arithmeticMean = Math.Round(arithmeticMean / m, 1);
    Console.WriteLine($"Cреднее арифметическое столбца № {i+1} {arithmeticMean}");
  }
}

void CreateArrayInt(int[,] array, int m, int n)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().Next(0, 11);
    }
  }
}

void WriteArrayInt (int[,] array, int m, int n)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber =(array[i, j]);
        Console.Write(alignNumber + " " );
      }
      Console.WriteLine();
  }
}

void CreateArrayDouble(double[,] array, int m, int n)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}
 void WriteArray (double[,] array, int m, int n)
 {
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " " );
      }
      Console.WriteLine();
  }
}


Z47();
Z50();
Z52();