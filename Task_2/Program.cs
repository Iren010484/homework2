/*Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет. Не использовать строки
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

bool Validate(int numb)
{
    if (numb < 100) 
        {   
            Console.WriteLine("Третьей цифры нет");
            return false;
        }
    return true;
}

int Cearch(int number)
{
    while(number > 999)
    {
        number = number /10;
    }
    return number = number %10;
}

int digit = ReadInt("Введите число");
if (Validate(digit))
{
    digit = Cearch(digit);
    Console.WriteLine($" Третья цифра = {digit}");
} 
