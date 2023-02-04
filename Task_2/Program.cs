// Задать двумерный массив следующим правилом: Aₘₙ = m+n



Console.WriteLine("Введите число m - количество строк:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число n - количество столбцов:");
int n = int.Parse(Console.ReadLine());

int[,] arr = new int[m, n];
for (int i = 0; i < m; i++)  //перебирает строки массива.
{
    for (int j = 0; j < n; j++) //перебирает столбцы массива.
    {
        arr[i, j] = i + j; // В каждой итерации циклов, значение i + j записывается в текущий элемент массива arr[i, j]. тоесть 0 + 0, 0 + 1, 0 + 2 вторая строка 1+0, 1+1, 1+2
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(arr[i, j] + " "); 
    }
    Console.WriteLine();  
}
