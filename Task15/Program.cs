/*Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.*/

Console.WriteLine("Введите число, обозначающее день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number>0 && number<8)
{
    if (number>5 && number<=7) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Такого дня недели не существует");

