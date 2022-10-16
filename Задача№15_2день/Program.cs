// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int Get(string message)
{
    Console.WriteLine(message);
    string numberAStr = Console.ReadLine();
    int numberA = Convert.ToInt32(numberAStr);
    return numberA;
}

int numberA = Get("Введите цифру обозначающую день недели, где 1 это понедельник а 7 воскресенье");

if (numberA > 5 && numberA <= 7)
{
    Console.WriteLine("Нет");
}
else if (numberA <= 5 && numberA >= 1)
{
     Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("неверное число");
} 
