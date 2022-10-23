// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int GetNumber(string message)
{
    int result; 
    while(true)
    {
        Console.WriteLine(message);
        string length = Console.ReadLine();
        int.TryParse(length, out int number);
        if (length.Length == 5 && number <= 99999 && number >= -99999 )
        {
            result = number;
            break;
        } 
        else
         {
            Console.WriteLine("Введите пятизначное число");
         }    
    }
    return result;
}

void Square(int N)
{
    string text = N.ToString();
    char[] obrtext = text.ToCharArray();
    Array.Reverse(obrtext);
    string finaltext = new string(obrtext);
    if(text==finaltext)
            {
                Console.WriteLine("Данная запись является палиндромом");
            }
            if (text!=finaltext)
            {
                Console.WriteLine("Данная запись не является палиндромом");
            }
}
    


int number = GetNumber("Введите число N");
Square(number);
