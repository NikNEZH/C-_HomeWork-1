// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Для того чтобы узнвть секрет нутеллы а также является ли число четным введите число");
string numberStrOne = Console.ReadLine() ?? ""; 

int numberOne = int.Parse(numberStrOne );
int newNumber = numberOne % 2;
if (newNumber > 0) 
{
    Console.WriteLine($"Увы число нечетное");
} 
else
{
    Console.WriteLine($"ИИИИИ ВЫ ВЫЙГРАЛИ АААВТОМОБИЛЬ ЧИСЛО ЧЕТНОЕ!!!!!");
}
