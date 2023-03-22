// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты двух точек, находящихся в 3D пространстве");
int n = 3;
int[] aray1 = new int [n];
int[] aray2 = new int [n];
Console.WriteLine("Введите по очереди координаты первой точки");
n = 0;
while (n < 3)
{
aray1[n] = Convert.ToInt32(Console.ReadLine());
n += 1;
}
Console.WriteLine("Введите по очереди координаты второй точки");
n = 0;
while (n < 3)
{
aray2[n] = Convert.ToInt32(Console.ReadLine());
n += 1;
}
double aray = Math.Sqrt((aray2[0]-aray1[0])*(aray2[0]-aray1[0])+(aray2[1]-aray1[1])*(aray2[1]-aray1[1])+(aray2[2]-aray1[2])*(aray2[2]-aray1[2]));
Console.WriteLine($"Длинна отрезка между вдумя точками равна {aray}");