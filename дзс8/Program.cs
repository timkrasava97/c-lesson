

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Z54()
{
  int columns = 7;
  int rows = 5;
  int[,] array = new int [rows, columns];

  CreateArrayInt(array, columns, rows);
  WriteArrayInt(array,  columns, rows);

  for(int i = 0; i < rows; i++)
  {
      for(int j = columns - 1; j > 0 ; j--)
      {
        for(int k = 0; k < j; k++)
        {
          if ( array[i, k] < array[i, k+1])
          {
                int temp = array[i, k];
                array[i, k] = array[i, k+1];
                array[i,k+1] = temp; 
          }
        //else k++;   незнаю зачем я его изначально залепил сюда, но ломал голову долго 
        }
      }
  }
  Console.WriteLine();
  WriteArrayInt(array, columns, rows);
}



void CreateArrayInt(int[,] array, int rows, int columns)
{
  for (int i = 0; i < columns; i++)
  {
    for (int j = 0; j < rows; j++)
    {
      array[i, j] = new Random().Next(0, 11);
    }
  }
}

void WriteArrayInt (int[,] array, int rows, int columns)
{
for (int i = 0; i < columns; i++)
  {
      for (int j = 0; j < rows; j++)
      {
        int alignNumber =(array[i, j]);
        Console.Write(alignNumber + "\t ");
      }
      Console.WriteLine();
  }
}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Z56()
{
int columns = 7;
int rows = 5;
int[,] array = new int [rows, columns];

CreateArrayInt(array, columns, rows);
 WriteArrayInt(array,  columns, rows);
int min = array[0,0];
int ResFirst =  firstRes(array);
int index = 0;

 Console.WriteLine($"сумма { index } строки равана {ResFirst}");

for(int i = 1; i < rows; i++)
{ int minSum = 0;
  for(int j = 0; j < columns; j++)
  {
    minSum += array[i, j];
  }
  Console.WriteLine($"сумма {i+1} строки равана {minSum}");
  if(minSum < ResFirst)
    {
      ResFirst = minSum;
      index = i;
    }
    
    
}
Console.WriteLine();
 Console.WriteLine($"Минимальная сумма находится в строке { index + 1 } и равана {ResFirst}");





int firstRes(int [ , ] array)
{
  int sum = 0;
  int column = array.GetLength(1);
  for(int j = 0; j < column; j++) sum += array[0, j];
  return sum;
}
}


void Z58()
{
  int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

}

 Z58();