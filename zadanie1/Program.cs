﻿//Программа, которая принимает на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N.
Console.Write("N=");
int N=Convert.ToInt32(Console.ReadLine());
for (int i=1;i<=N; i=i+1)
{
//Возведение в степень
double res =Math.Pow( i,3);
Console.WriteLine($"{i} ^ {3} = {res}");
}

