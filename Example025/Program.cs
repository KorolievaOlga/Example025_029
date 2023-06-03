// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());

int GetExponentiation(int b, int a)
{
    int exp = a;
    for (int i = 1; i < b; i++)
    {
        exp = exp * a;  
    }
    return exp;
}
Console.WriteLine($"Число {a} в степени {b} равно {GetExponentiation(b, a)}");