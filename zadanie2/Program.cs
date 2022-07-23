//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("x1=");
int x1=Convert.ToInt32(Console.ReadLine());

Console.Write("y1=");
int y1=Convert.ToInt32(Console.ReadLine());

Console.Write("z1=");
int z1=Convert.ToInt32(Console.ReadLine());

Console.Write("x2=");
int x2=Convert.ToInt32(Console.ReadLine());

Console.Write("y2=");
int y2=Convert.ToInt32(Console.ReadLine());

Console.Write("z2=");
int z2=Convert.ToInt32(Console.ReadLine());

double AB=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.Write("AB=");
Console.WriteLine(AB);

