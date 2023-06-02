//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

//Console.WriteLine("Ведите Число");
//int sumNumbers = Convert.ToInt32(Console.ReadLine())

/*Console.WriteLine("Введите число ");
string input = Console.ReadLine();
Console.WriteLine($"Количество цифр в строке {input.Length}");
*/ 

Console.WriteLine("Ведите Число");
bool isNumber = int.TryParse(Console.ReadLine(), out int result);
if (isNumber)
{
    int count = 1;
    while (result > 0)
    {   
        result /= 10;
        count += 1;
    }
    Console.WriteLine($"Количество цифр в строке {count}");
}
else
{
    Console.WriteLine("Вы ввели не число");
}
