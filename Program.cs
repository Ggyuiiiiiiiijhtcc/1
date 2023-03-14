using System;
#region 1 Написать программу, которая находит среднее арифметическое значение из двух чисел.
Console.WriteLine("Введите первое число");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
double b = double.Parse(Console.ReadLine());
Console.WriteLine((a + b) / 2);
#endregion

#region 2.	Написать программу, которая находит корень линейного уравнения ax + b = 0.
Console.WriteLine("Введи первое число ");
double a1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введи второе число");
double a2 = double.Parse(Console.ReadLine());
Console.WriteLine(-a2 / a1);
#endregion

#region 3.Пользователь вводит число. Программа вычисляет 3-ю степень этого числа.
Console.WriteLine("Введи число");
int aa1 = int.Parse(Console.ReadLine());
Console.WriteLine(a*a*a);
#endregion

#region 4.Написать программу, которая  предлагает пользователю ввести радиус окружности  и считает площадь этой окружности. Число Pi задать в программе как константу
const double Pi = 3.14;
Console.WriteLine("введи радиус");
double f = double.Parse(Console.ReadLine());
Console.WriteLine(Pi * (f * f));
#endregion

#region 5.Написать программу, которая  переводит доллары в гривны. Курс доллара задать в программе как константу
const double dol = 36.78;
Console.WriteLine("Введи суму в гривнах");
double f1 = double.Parse(Console.ReadLine());
Console.WriteLine(dol * f1);
#endregion

#region 6.	Написать программу, которая переводит сухопутные мили в километры. Одна миля – 1.609 км.
const double mil = 1.609;
Console.WriteLine("Введи мили ");
double km = double.Parse(Console.ReadLine());
Console.WriteLine(mil * km);
#endregion
#region 7.Написать программу, которая предлагает пользователю ввести год своего рождения и текущий год и в ответ показывает возраст пользователя.
Console.Write("Введите год своего рождения: ");
int birthYear = int.Parse(Console.ReadLine());
Console.Write("Введите текущий год: ");
int currentYear = int.Parse(Console.ReadLine());
int age = currentYear - birthYear;
Console.WriteLine("Ваш возраст: {0}", age);
#endregion
#region 8.	Написать программу, которая находит процент P от суммы S
Console.WriteLine("Введи суму S:");
double s = double.Parse(Console.ReadLine());
Console.WriteLine("Введи процент P:");
double p = double.Parse(Console.ReadLine());
double si = s * p / 100;
Console.WriteLine("Процент = {0} ",si);
#endregion
#region 9.Написать программу для определения диаметра окружности, которую можно получить из отрезка проволоки длиной Х (X задает пользователь).
const double a21 = 3.14;
Console.WriteLine("Введи длину проволки");
double wire = double.Parse(Console.ReadLine());
double diameter = wire / a21;
Console.WriteLine("Диаметр окружности{0} метров: {1}",wire, diameter);
#endregion
#region 10.	Пользователь трижды вводит достоинство купюр и их количество. Программа должна посчитать общую сумму денег
int sum = 0;
for (int i = 0;i <3; i++)
{
    sum++;
    Console.WriteLine("Введите достоинство купюр №{0}", i);
    int bb =int.Parse(Console.ReadLine());
    Console.WriteLine("введи количиство купюр №{0}", i);
    int aa = int.Parse(Console.ReadLine());
    sum += bb*aa;
}
Console.WriteLine(sum);
#endregion