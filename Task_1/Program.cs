// Показать двумерный массив размером m×n заполненный вещественными числами
// Задать двумерный массив следующим правилом: Aₘₙ = m+n
// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// В матрице чисел найти сумму элементов главной диагонали

Console.WriteLine("введи число m количество строк");
 int m = int.Parse(Console.ReadLine());
Console.WriteLine("введи число n количество столбиков");
 int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

for (int rows = 0; rows < m; rows++)
{
    for (int colums = 0; colums < n; colums++)
    {
    
        array[rows, colums] = new Random().Next(1,10);;
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