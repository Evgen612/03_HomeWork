// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Ввeдите пятизначное число: ");
int num = int.Parse(Console.ReadLine()); 
if(num < 10000 || num > 99999)
{
    Console.Write("Число не является пятизначным");
}
else
{int a = num % 10;
int a1 = num / 10000;
int b = num % 100;
int b1 = num / 1000;

if(a == a1 || b == b1)
{
    Console.Write($"{num} --> является");
}
else
{
    Console.Write($"{num} -->не является");
}

}
