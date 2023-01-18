// Задача 27: Напишите программу, которая 
// принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigitNumbers = SumDigitNumbers(number);

int SumDigitNumbers(int num)
{
    int sum = 0;
    while (num > 0)
    {
    int i = num % 10;    
       sum +=i;
       num = num / 10;
    }
    return sum;
}

if (number > 0)
{
    Console.WriteLine($"Сумма цифр в числе {number} = {sumDigitNumbers}");
}
else
{
    Console.WriteLine("Вы ввели некорректное число");
}