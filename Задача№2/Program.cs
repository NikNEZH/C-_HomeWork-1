// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите два чилса для определения какой из них больше");
string numberStrOne = Console.ReadLine() ?? ""; 
string numberStrTwo = Console.ReadLine() ?? "";
int numberOne = int.Parse(numberStrOne );
int numberTwo = int.Parse(numberStrTwo );

if (numberOne > numberTwo) 
{
    Console.WriteLine($"Число {numberOne} больше чем {numberTwo}, но это не точно");
} 
else 
{
   Console.WriteLine($"Ходят легенды что это число {numberTwo} больше чем это {numberOne}  ");
}
