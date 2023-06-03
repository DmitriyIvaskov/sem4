// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Ведите Число");
bool isNumber = int.TryParse(Console.ReadLine(), out int result);
if (isNumber)
{
    int sum = 0;
    while (result > 0)
    {   
        int length = result % 10;
        result /= 10;
        sum = sum + length ;
    }
    Console.WriteLine($"Сумма цифр {sum}");
}
else
{
    Console.WriteLine("Вы ввели не число");
}
