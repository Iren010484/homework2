// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Не использовать строки
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
string digit = Console.ReadLine(); 
int three_digit = Convert.ToInt32(digit);
if (three_digit < 100 || three_digit >=1000) 
    {Console.WriteLine("Вы ввели не трехзначное число");}
else
{int number = three_digit % 100 / 10;
Console.WriteLine($" Вторая цифра = {number}");} 