// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int DeleteSecondDigit(int num)
// {
//     int result = num / 10 % 10;
//     return result; 
// }
// int num = new Random().Next(100, 999 + 1);
// System.Console.WriteLine(num);
// System.Console.WriteLine(DeleteSecondDigit(num));


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int ThirdDigit(int num)
// {
//    while (num > 999)
//    {
//     num /= 10;   
//    }
//    return num % 10;
//     }

// bool NumbercCorrectness (int num)
// {
//     if (num < 100)
//     {
//         System.Console.WriteLine("Третьей цифры нет! ");
//          return false;
//          }
//          {
//             return true;
//          }
// }
// int Prompt (string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result; 
// }
// int num = Prompt ("Введите число: ");
// if (NumbercCorrectness(num))
// {
//     System.Console.WriteLine(ThirdDigit(num));
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result; 
}

bool IsWeekend (int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    {
        return false;
    }
}
bool ValidateWeekday (int num)
{
    if (num > 0 && num <= 7)
    {
        return true;
    }
    System.Console.WriteLine("Это не день недели! ");
    return false; 
}
int weekDay = Prompt ("Введите день недели: ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        System.Console.WriteLine("Наконец-то выходной! ");

    }
    else 
    {
        System.Console.WriteLine("Придется поработать ");
    }
}
