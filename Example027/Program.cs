/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int GetSumNumbers(int n)
{
    int sum = 0;
    for(int i = n; i > 0; i++)
    {
        int num = n % 10;
        n = n / 10;
        sum = sum + num;
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе равна {GetSumNumbers(n)}");