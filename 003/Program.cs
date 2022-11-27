// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели:");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 | num==7 ) Console.WriteLine("Да, это выходной");
else if (num >=1 && num<=5) Console.WriteLine("Нет, это рабочий");
else Console.WriteLine("Ошибка! Необходимо ввести цифру от 1 до 7.");
