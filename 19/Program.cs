/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int last = 0;
int polindrom = 0;
int ostatok = x;
while (ostatok > 0)
{
    last = ostatok % 10;
    ostatok = ostatok / 10;
    polindrom = polindrom * 10 + last; 
}
Console.WriteLine(polindrom == x ? "да" : "нет");