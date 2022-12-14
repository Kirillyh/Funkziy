int[,] matrix = new int[3, 4];    // Задаем двумерный массив


for (int i = 0; i < matrix.GetLength(0); i++)     // Внешний цикл клацаюший строки   for (int i = 0; i<3; i++) == matrix.GetLength(0)
{
    for (int j = 0; j < matrix.GetLength(1); j++) // Внутренний цикл клацаюший столбцы     for (int j = 0; j < 4; j++) == matrix.GetLength(1)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine(); //Переход на новою строку чтобы было красиво
}