// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Random rnd = new Random(); 
int number = rnd.Next(100, 1000);

int Get(int N)
{
    int A = N % 100;
    int B = A % 10;
    int C = A - B;
    C = C/10;
    return C;
}

int result = Get(782);

Console.WriteLine($"{result}");
