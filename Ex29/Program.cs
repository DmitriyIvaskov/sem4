﻿//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int size = 8;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(); 
}
Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");

// Может я что то не допонял??? Ну типо я убрал в Next числа и он выдает рандомные любые числа, или я что то не так понял?