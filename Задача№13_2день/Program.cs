// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int Get(string message)
{
    Console.WriteLine(message);
    string numberAStr = Console.ReadLine();
    int numberA = Convert.ToInt32(numberAStr);
    return numberA;
}

int numberA = Get("Введите число:");

if (numberA > 100 && numberA < 1000)
{
    int result = numberA % 10;
    Console.WriteLine($"{result}");
}
else if ( numberA > 1000 && numberA < 10000)
{
    int result = numberA / 10;
    result = result % 10;
    Console.WriteLine($"{result}");
} 
else if ( numberA > 10000 && numberA < 100000)
{
    int result = numberA / 100;
    result = result % 10;
    Console.WriteLine($"{result}");
} 
else if (numberA < 100)
{
    Console.WriteLine("третьей цифры нет");
} 
else
{
    Console.WriteLine("Число больше 100000");
} 

// Знаю что сделал не совсем верно и коряво но не смог придумать другого решения