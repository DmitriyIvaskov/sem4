//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите чсило A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

int sum = A;

for (int i = 1; i < B; i++)
{
    sum *= A;
}
Console.WriteLine($"Число A в степени числа B = {sum}");