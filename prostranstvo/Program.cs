//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("доброго дня");

int x1 = ReadInt("Введите X координата первой точки: ");
int y1 = ReadInt("Введите Y координата первой точки: ");
int z1 = ReadInt("Введите Z координата первой точки: ");
int x2 = ReadInt("Введите X координата второй точки: ");
int y2 = ReadInt("Введите Y координата второй точки: ");
int z2 = ReadInt("Введите Z координата второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

