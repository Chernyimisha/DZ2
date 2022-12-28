/*Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.*/

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if ( number > 99 && number < 1000)
{
    int number1 = number % 100;
    int result = number1 / 10;
    Console.WriteLine($"Вторая цифра числа {number} равна {result}");
}
else Console.WriteLine("Ввели неправильное число");
