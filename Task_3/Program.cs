/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

bool Validate(int numb)
{
    if (numb > 7 || numb < 1) 
        {   
            Console.WriteLine("Цифра введена не корректно");
            return false;
        }
    return true;
}

bool Weekend(int number)
{
    while(number > 5)
    {
       return true;
    }
    return false;
}

int digit = ReadInt("Введите номер дня недели");
if (Validate(digit))
{
   if (Weekend(digit))
   {
    Console.WriteLine("Да");
   }
   else
   {
    Console.WriteLine("Нет");
   }
} 
