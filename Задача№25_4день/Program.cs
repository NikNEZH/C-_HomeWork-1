using System;
// Задача 25: Напишите цикл, который принимает на 
// вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16 


/* Это способ решения через поинт 
================================================================*/

// double GetNubCoub(Point firstPoint) 
// {
//     double distance3D = Math.Pow(firstPoint.A, firstPoint.B);

//     return distance3D; 
// }

// int GetNumber(string message)
// {
//     Console.WriteLine(message);
//     return int.Parse(Console.ReadLine());
// }

// Point GetPoint()
// {
//     Point p = new Point();

//     p.A = GetNumber("ВВедите число А");
//     p.B = GetNumber("ВВедите число B");
//     return p;
// }

// Point firstPoint = GetPoint();

// double distance = GetDis3D(firstPoint);

// Console.WriteLine($"Расстояние между точками равно = {distance}");


// class Point
// {
//     public int A { get; set; }
//     public int B { get; set; }
// }


/* Это способ решения через цикл  
================================================================*/ 

int GetNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int nubmerA = GetNumber("ВВедите число А");
int numberB = GetNumber("ВВедите число B"); 
double result = 0;
for (int i = 0; i <= nubmerA; i++)
{
    result = Math.Pow(i,  numberB); 
} 

Console.WriteLine($"{result}"); 
