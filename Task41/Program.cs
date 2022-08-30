// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int k = 0;
for(int i = 0; i < n; i++)
{
    Console.WriteLine("Введите очередное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number > 0) k = k + 1;
}
Console.WriteLine($"Количество положителных чисел: " + k);
