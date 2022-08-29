//Задача 64: Задайте значения M и N. Напишите рекурсионный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
//M = 1; N = 9. -> "3, 6, 9"
//M = 13; N = 20. -> "15, 18"

void Z64()
{
    int m = InputNumbers("Введите m: ");
    int n = InputNumbers("Введите n: ");
    int temp = m;
    if (m > n) 
    {
    m = n; 
    n = temp;
    }

    PrintOST(m, n);
}


void PrintOST(int m, int n)
{    
  if (m % 3 == 0 && m <= n)
  {
    Console.Write($"Сумма элементов= {m} ");
    if(m >= n) return;
  }
  
  PrintOST(m + 1, n);
}





// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void Z66()
{
    Console.Clear();
    int m = InputNumbers("Введите m: ");
    int n = InputNumbers("Введите n: ");
    int temp = m;
    if (m > n) 
    {
    m = n; 
    n = temp;
    }

    PrintSumm(m, n, temp=0);
}
void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}









// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
void Z68()
{
Console.Clear();
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");
}
int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Z64();
// Z66();
//Z68();
