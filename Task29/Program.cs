// Напишите программу, которая задаёт массив из рандомного количества элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputNum (string message)
{
    Console.WriteLine(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int[] GenerateArray (int Length, int minValue, int maxValue)
{
    int[] array = new int [Length];
    Random random = new Random();
    {
        for (int i = 0; i < Length; i++)
        {
            array[i] = random.Next(minValue, maxValue +1);
        }
    }
    return array;
}
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");

}

int lenght = InputNum("Длина массива: ");
int min = InputNum("Начальное значение для диапазона случайного числа: ");
int max = InputNum("Конечное значение для диапазона случайного числа: ");
int [] array = GenerateArray(lenght, min, max);
PrintArray(array);



