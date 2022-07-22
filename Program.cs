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

