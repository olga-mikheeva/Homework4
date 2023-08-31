// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16 

// ввод числа с экрана
int InputNum (string message) 
{
    Console.WriteLine(message); // выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine(); // Выводим значение
    int result = int.Parse(ReadInput); // Приводим к числу
    return result; // возвращаем результат
}

int Power(int powerBase, int exponent) // возведение в степень
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent (int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = InputNum("Введите основание: ");
int exponent = InputNum("Введите показатель степени: ");
if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}


