// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12 

 
// int result = 0;
// int Get (string msg) 
// {
//     Console.WriteLine(msg);
//     int number = int.Parse(Console.ReadLine());
//     for (int i = 0; i <= number; i++)
//     { 
//     result = result + (number % 10);
//     number = number / 10;
//     }
    
//     return result;
// }

// int a = Get("Ddd");

// Console.WriteLine($"{a}");

/* Тот что сверху код почему не работал с данными начинающимися на 1 или если 
идут два ноля подрят например 20022 я не выяснил почему спрошу об этом на семинаре
или у вас в телеге */ 
int Replace(string msg)
{
    Console.WriteLine(msg);
    string numberStr = Console.ReadLine();
    int length = numberStr.Length;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        char value =  numberStr[i]; 
        int numberValue = int.Parse(value.ToString());
        result = result + numberValue;
       
    }
    return result;
} 

int resultFin = Replace("Enter number");
Console.WriteLine($"{resultFin}");