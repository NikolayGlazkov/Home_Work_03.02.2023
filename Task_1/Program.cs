// Показать двумерный массив размером m×n заполненный вещественными числами

Console.WriteLine("введи число m количество строк");
 int m = int.Parse(Console.ReadLine());
Console.WriteLine("введи число n количество столбиков");
 int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

for (int rows = 0; rows < m; rows++)
{
    for (int colums = 0; colums < n; colums++)
    {
        Console.WriteLine("введите вещественное число");
        array[rows, colums] = new Random().Next(1,10); // рандомом заполяем массив
    }
}

for (int rows = 0; rows < m; rows++)
{
    for (int colums = 0; colums < n; colums++)
    {
        Console.Write($"{array[rows, colums]} ");
    }
    Console.WriteLine();
}