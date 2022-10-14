// Двумерный массив с рандомным заполненинием 




/*void PrintArray(int[,] mat)
{
    for (int i=0; i<mat.GetLength(0); i++)
    {
        for (int j = 0; j<mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i,j]} ");
        }
        Console.WriteLine();
    } 
}

void FillArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i,j] = new Random().Next(1,10);
        }
    }
}

int [,] matrix = new int[3,4];
FillArray(matrix);
PrintArray(matrix);*/
// Console.Clear();


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Console.Clear();
// Console.WriteLine("Введите некоторое количество чисел");

/*Console.Write("Введите колличество чисел: ");
int n = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int x = int.Parse(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine($"Положительных чисел: {count}");
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine($"Введите значение k1 ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите значение b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());
int x = (-b2 + b1)/(-k1 + k2);
int y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
