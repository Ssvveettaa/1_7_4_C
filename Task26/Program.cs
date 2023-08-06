// Задача 26:
// Напишите программу, которая
// принимает на вход число
// и выдаёт количество цифр в числе.
// 456   –>3
// 78    –>2
// 89126 –>5

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = QuantityDigits(number);
Console.WriteLine($"Количество цифр в числе {number} = {result}.");

int QuantityDigits(int num)
{
    int count = 0;
    if (num == 0) count = 1; // Будем считать, что в числе 0 есть 1 цифра.
    while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}
