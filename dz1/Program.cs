/* Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь. */

int m;
Console.Write($"Введите количество чисел: ");
int.TryParse(Console.ReadLine()!, out m);

int[] array = new int[m];

for (int i = 0; i < m; i++)
{
    Console.Write($"[{i}] = ");
    int.TryParse(Console.ReadLine()!, out array[i]);
}
int k = 0;
foreach (var i in array)
     if (i > 0)
         k++;
Console.Write($"{k} чисел больше 0");



