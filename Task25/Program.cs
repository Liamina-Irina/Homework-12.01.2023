// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите целое число A: ");
Console.Write("Введите целое число B: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiationNumbers = ExponentiationNumbers(number);
Console.WriteLine($"число А {numberA} в степени числа B {numberB} = {exponentiationNumbers}");

void ExponentiationNumbers(int numA, int numB)
{
    int exp = 0;
    for (numB > 0;)
    {
        exp = numA * numB;
    }
    return exp;
}
