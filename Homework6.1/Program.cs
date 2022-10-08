// Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/* 5
0
7
8
-2
-2 -> 2

5
1
-7
567
89
223-> 3 */

Console.Clear();
Console.WriteLine("Введите целое положительное число M: ");
int countM = int.Parse(Console.ReadLine()!);
int countPos = 0;

for (int i = 0; i < countM; i++)
{
    Console.WriteLine($"Введите любое целое число ещё {countM - i} раз:  ");
    int countTemp = int.Parse(Console.ReadLine()!);
    if (countTemp > 0){
        countPos++;
    };
    /* Console.WriteLine($"{countTemp}"); */
}


 Console.WriteLine($"Чисел больше нуля введено: {countPos}");