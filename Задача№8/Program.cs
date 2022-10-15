// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число чтобы узнать все четные числа которое оно принимает...ну и секрет колбассы");
string numberStrOne = Console.ReadLine() ?? ""; 

int numberOne = int.Parse(numberStrOne );
int result = 1;
while (result <= numberOne)
{
    int newResult = result % 2;
   if (newResult > 0)
   {
    Console.WriteLine("");
   } 
   else
   {
    Console.WriteLine($"{result}");
   }
   result++;
    
} 



