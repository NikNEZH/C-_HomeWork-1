// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// пример из 5 элементов:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();


/* первый способ решения */ 

// static void Main()
//         {
//             // int size = 8;
//             int[] array = new int[8];
//             Random myRandom = new Random();
 
//             Console.WriteLine("Вывод с помощью for");
//             for (int i = 0; i < array.Length; i++)
//             {
//                 array[i] = myRandom.Next(0, 9);
//                 Console.Write("{0} ", array[i]);
//             }
//         } 

        // Main();

/* второй способ решения */
Console.WriteLine("Введите 8 элементов через пробел");
string simvolStr = Console.ReadLine();
char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
string[] arrSimvols = simvolStr.Split(delimiterChars);
Console.WriteLine($"Вы ввели  {arrSimvols.Length} элементов");
if ( arrSimvols.Length > 7 && arrSimvols.Length < 9) 
{
    foreach (var simvol in arrSimvols)
    {
    Console.Write("{0} ", simvol);
    }
} else
{
    Console.WriteLine("Введите ровно 8 элементов (символов)");
}
