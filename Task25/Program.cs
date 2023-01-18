// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите целое число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiationNumbers = ExponentiationNumbers(numberA, numberB);

int ExponentiationNumbers(int numA, int numB)
{
    int exp = 1;
    for (int i = 1; i <= numB; i++)
    {
        exp = exp * numA;
    }
    return exp;
}

if(numberB > 0)
{
    Console.WriteLine($"число А в степени числа B = {exponentiationNumbers}");
}
else
{
    Console.WriteLine("Вы ввели ненатуральное число B");
}