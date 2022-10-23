// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125 

int GetNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
} 

int number = GetNumber("Введите число");
int result = 1;
for (int i = 1; i <= number; i++)
{
    result = i*i*i; 
    Console.Write($" {result},");
}  

