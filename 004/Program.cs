// Задача FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, 
// кратных пяти — слово Buzz. Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. 
// Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.
using System.Diagnostics;

void FiBuFunc() 
{
    for (int i = 1; i <= 100; i++)
    {
        string result = "";
        if (i % 3 == 0) result = "Fizz";
        if (i % 5 == 0) result += "Buzz";
        if (result == "") result = Convert.ToString(i);
        Console.WriteLine(result);
    }
}
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

FiBuFunc();  

stopwatch.Stop();
Console.WriteLine("время исполнения составило : " + stopwatch.ElapsedMilliseconds + " миллисекунд");
