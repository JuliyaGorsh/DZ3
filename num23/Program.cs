// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;


for (; a <= n; a++)
{

Console.WriteLine($"Кубы числа от 1 до {n}: {Math.Pow(a, 3)}");

}