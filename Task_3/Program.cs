// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты


using System;


int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] arr = new int[m, n]; // двумернй массив


for (int i = 0; i < m; i++)  // заполняем массив числами i * j  тоесть: 0*0 первая линия втораяя 1*0, 1*1, 1*2 третяя 2*0, 2*1, 2*4 
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = i * j; 
    }
}

for (int i = 0; i < m; i++)  // если i и j деляться на 2 без остатка заменяем число в этом индексе на квадрат этого числа 
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
}

for (int i = 0; i < m; i++)  // вывод на консоль 
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
