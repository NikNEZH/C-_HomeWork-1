// Задача 4: Напишите программу, которая принимает на вход три числа и
//  выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Братишка введи три чилса для определения какой из них больше");
string numberStrOne = Console.ReadLine() ?? ""; 
string numberStrTwo = Console.ReadLine() ?? "";
string numberStrThre = Console.ReadLine() ?? "";
int numberOne = int.Parse(numberStrOne );
int numberTwo = int.Parse(numberStrTwo );
int numberThre = int.Parse(numberStrThre );

int max = 0;
if (numberOne > numberTwo) 
{
    max = numberOne;
} 
if ( numberThre > numberOne)
{
    max = numberThre;
}
if (numberTwo > numberThre)
{
    max = numberTwo;
    
}

Console.WriteLine($"Как поговоривают местные завсегдатые это число {max} самое большое из всех что им поподались");