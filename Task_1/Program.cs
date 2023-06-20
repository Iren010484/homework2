// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Не использовать строки
// 456 -> 5
// 782 -> 8
// 918 -> 1
int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

bool Validate3sing(int numb)
{
    if (numb < 100 || numb >=1000) 
        {   
            Console.WriteLine("Вы ввели не трехзначное число");
            return false;
        }
    return true;
}

int three_digit = ReadInt("Введите трехзначное число");
if (Validate3sing(three_digit))
{
    int number = three_digit % 100 / 10;
    Console.WriteLine($" Вторая цифра = {number}");
} 