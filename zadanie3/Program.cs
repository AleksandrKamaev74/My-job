// Программa, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
Console.Write("Число N=");
int N=Convert.ToInt32(Console.ReadLine());
int temp=N;
int rev=0;
while (N>0)
{
   int dig=N%10;    
   rev=rev*10+dig;
   N=N/10;
}

if(temp==rev)
{
Console.Write("Число является палиндромом");
Console.WriteLine();
}
else
{
Console.Write("Число не палиндром"); 
Console.WriteLine();  
}






