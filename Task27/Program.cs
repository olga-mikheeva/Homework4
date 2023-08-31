// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNum (string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int SumAllDigit (int number)
{
int result = 0;
while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}



int number = InputNum("Введите число: ");
Console.WriteLine($"Сумма всех цифр в числе {number} = {SumAllDigit(number)}");
