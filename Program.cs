void Zadach19()
{
Console.WriteLine("введите пятизначно число");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 10000 || num > 99999)
{
   Console.WriteLine("Введено некоркетное число" + " Введите заново");
    num = Convert.ToInt32(Console.ReadLine());
    
}
string strNum = Convert.ToString(num);
if (strNum[0] == strNum[4] && strNum[1]== strNum[3])
    Console.WriteLine("да полиндром");
 else Console.WriteLine("не полиндром");
}

// Zadach19();


void Zadacha23()
{
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int begin = 1;
while (begin <= num)
    {
        int result = begin * begin * begin;
        begin ++;
        Console.Write(" " + result);
    }
}

// Zadacha23()



// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
void Zadacha24()
{
Console.WriteLine("\n Задача 21");
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
}

void Z3() 
{

int [] array = new int [8];
int i = 0;
while (i<array.Length) 
{
int num = new Random().Next(0, 2);
array [i] = num;
Console.Write("[ " + num + " ]" );
i++;
}



}

// Задача 25: Используя определение степени числа, напишите цикл,
//  который принимает на вход два натуральных числа (A и B) и возводит число A в степень B
void Z25()
{
Console.WriteLine("Введите числj");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числj");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
for(int i = 1; i<b; i++)
{
    result *= a;
}
Console.WriteLine(result);
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Z27()
{
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(num > 0)
{
    sum += num % 10;
    num /= 10;
}
Console.WriteLine(sum);
}

// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
void Z29()
{
int size = 8;
int[] array = new int [size];
Random random = new Random();
for(int i = 0; i < size; i ++)
{
    array[i] = random.Next(-10, 10);
}


for(int i = array.Length - 1; i > 0; i --)
{
    for(int c = 0; c < i; c++)
    {
        if(Math.Abs(array[c]) > Math.Abs(array[c+1]))
        {
            int temp = array[c];
            array[c] = array[c+1];
            array[c+1] = temp;
        }
    }
}
for(int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
}

